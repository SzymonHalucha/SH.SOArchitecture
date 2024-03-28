using UnityEngine;
using UnityEngine.Events;
using SH.SOArchitecture.Events;

namespace SH.SOArchitecture.ScriptableListeners
{
    [CreateAssetMenu(menuName = "SH/Architecture/Listeners/Empty", fileName = "New Empty Listener", order = 1)]
    public class ScriptableEventListener : ScriptableObject
    {
        [SerializeField] private ScriptableEvent _scriptableEvent;
        [SerializeField] private UnityEvent _unityEvent;

        public void Subscribe()
        {
            if (_scriptableEvent != null)
            {
                _scriptableEvent.Subscribe(OnEventInvoked);
            }
        }

        public void Unsubscribe()
        {
            if (_scriptableEvent != null)
            {
                _scriptableEvent.Unsubscribe(OnEventInvoked);
            }
        }

        private void OnEnable()
        {
            Subscribe();
        }

        private void OnDisable()
        {
            Unsubscribe();
        }

        public void OnEventInvoked()
        {
            _unityEvent?.Invoke();
        }
    }

    public abstract class ScriptableEventListener<T> : ScriptableObject
    {
        [SerializeField] private ScriptableEvent<T> _scriptableEvent;
        [SerializeField] private UnityEvent<T> _unityEvent;

        public void Subscribe()
        {
            if (_scriptableEvent != null)
            {
                _scriptableEvent.Subscribe(OnEventInvoked);
            }
        }

        public void Unsubscribe()
        {
            if (_scriptableEvent != null)
            {
                _scriptableEvent.Unsubscribe(OnEventInvoked);
            }
        }

        private void OnEnable()
        {
            Subscribe();
        }

        private void OnDisable()
        {
            Unsubscribe();
        }

        public void OnEventInvoked(T arg)
        {
            _unityEvent?.Invoke(arg);
        }
    }

    public abstract class ScriptableEventListener<T0, T1> : ScriptableObject
    {
        [SerializeField] private ScriptableEvent<T0, T1> _scriptableEvent;
        [SerializeField] private UnityEvent<T0, T1> _unityEvent;

        public void Subscribe()
        {
            if (_scriptableEvent != null)
            {
                _scriptableEvent.Subscribe(OnEventInvoked);
            }
        }

        public void Unsubscribe()
        {
            if (_scriptableEvent != null)
            {
                _scriptableEvent.Unsubscribe(OnEventInvoked);
            }
        }

        private void OnEnable()
        {
            Subscribe();
        }

        private void OnDisable()
        {
            Unsubscribe();
        }

        public void OnEventInvoked(T0 arg0, T1 arg1)
        {
            _unityEvent?.Invoke(arg0, arg1);
        }
    }

    public abstract class ScriptableEventListener<T0, T1, T2> : ScriptableObject
    {
        [SerializeField] private ScriptableEvent<T0, T1, T2> _scriptableEvent;
        [SerializeField] private UnityEvent<T0, T1, T2> _unityEvent;

        public void Subscribe()
        {
            if (_scriptableEvent != null)
            {
                _scriptableEvent.Subscribe(OnEventInvoked);
            }
        }

        public void Unsubscribe()
        {
            if (_scriptableEvent != null)
            {
                _scriptableEvent.Unsubscribe(OnEventInvoked);
            }
        }

        private void OnEnable()
        {
            Subscribe();
        }

        private void OnDisable()
        {
            Unsubscribe();
        }

        public void OnEventInvoked(T0 arg0, T1 arg1, T2 arg2)
        {
            _unityEvent?.Invoke(arg0, arg1, arg2);
        }
    }

    public abstract class ScriptableEventListener<T0, T1, T2, T3> : ScriptableObject
    {
        [SerializeField] private ScriptableEvent<T0, T1, T2, T3> _scriptableEvent;
        [SerializeField] private UnityEvent<T0, T1, T2, T3> _unityEvent;

        public void Subscribe()
        {
            if (_scriptableEvent != null)
            {
                _scriptableEvent.Subscribe(OnEventInvoked);
            }
        }

        public void Unsubscribe()
        {
            if (_scriptableEvent != null)
            {
                _scriptableEvent.Unsubscribe(OnEventInvoked);
            }
        }

        private void OnEnable()
        {
            Subscribe();
        }

        private void OnDisable()
        {
            Unsubscribe();
        }

        public void OnEventInvoked(T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            _unityEvent?.Invoke(arg0, arg1, arg2, arg3);
        }
    }
}