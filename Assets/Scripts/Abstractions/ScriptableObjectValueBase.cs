using System;
using UnityEngine;
using Utils;

namespace UserControlSystem.UI.Model
{
    [CreateAssetMenu(fileName = "ScriptableObjectValueBase", menuName = "Strategy Game/ScriptableObjectValueBase", order = 0)]
    public class ScriptableObjectValueBase<T> : ScriptableObject, IAwaitable<T>
    {
        public T CurrentValue { get; private set; }
        public Action<T> OnNewValue;
        public void SetValue(T target)
        {
            CurrentValue = target;
            OnNewValue?.Invoke(target);
        }
        public IAwaiter<T> GetAwaiter()
        {
            return new NewValueNotifier<T>(this);
        }
        public class NewValueNotifier<TAwaited> : AwaiterBase<TAwaited>
        {
            private readonly ScriptableObjectValueBase<TAwaited> _scriptableObjectValueBase;
            public NewValueNotifier(ScriptableObjectValueBase<TAwaited> scriptableObjectValueBase)
            {
                _scriptableObjectValueBase = scriptableObjectValueBase;
                _scriptableObjectValueBase.OnNewValue += OnNewValue;
            }
            private void OnNewValue(TAwaited value)
            {
                _scriptableObjectValueBase.OnNewValue -= OnNewValue;
                OnWaitFinish(value);
            }
        }
    }
}