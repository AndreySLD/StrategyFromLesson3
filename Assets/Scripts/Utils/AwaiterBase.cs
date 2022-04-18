using System;

namespace Utils
{
    public abstract class AwaiterBase<TAwaited> : IAwaiter<TAwaited>
    {    
        private Action _continuation;
        private TAwaited _result;
        private bool _isCompleted;

        public bool IsCompleted => _isCompleted;
        public TAwaited GetResult() => _result;

        public void OnCompleted(Action continuation)
        {
            if (_isCompleted)
                continuation?.Invoke();
            else
                _continuation = continuation;
        }
        protected void OnWaitFinish(TAwaited result)
        {
            _result = result;
            _isCompleted = true;
            _continuation?.Invoke();
        }
    }
}
