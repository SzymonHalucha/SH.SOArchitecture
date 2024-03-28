using System;
using UnityEngine;
using SH.SOArchitecture.ScriptableListeners;

namespace SH.SOArchitecture.Events
{
    [CreateAssetMenu(menuName = "SH/Architecture/Events/Empty", fileName = "New Empty Event", order = 1)]
    public class ScriptableEvent : ScriptableObject
    {
        private event Action Listeners;

        private void OnDestroy()
        {
            Listeners = null;
        }

        [ContextMenu("Invoke")]
        public void Invoke()
        {
            Listeners?.Invoke();
        }

        public void Clear()
        {
            Listeners = null;
        }

        public void Subscribe(ScriptableEventListener listener)
        {
            Listeners += listener.OnEventInvoked;
        }

        public void Subscribe(Action listener)
        {
            Listeners += listener;
        }

        public void Unsubscribe(ScriptableEventListener listener)
        {
            Listeners -= listener.OnEventInvoked;
        }

        public void Unsubscribe(Action listener)
        {
            Listeners -= listener;
        }
    }

    public abstract class ScriptableEvent<T> : ScriptableObject
    {
        private event Action<T> Listeners;

        private void OnDestroy()
        {
            Listeners = null;
        }

        public void Invoke(T arg)
        {
            Listeners?.Invoke(arg);
        }

        public void Clear()
        {
            Listeners = null;
        }

        public void Subscribe(ScriptableEventListener<T> listener)
        {
            Listeners += listener.OnEventInvoked;
        }

        public void Subscribe(Action<T> listener)
        {
            Listeners += listener;
        }

        public void Unsubscribe(ScriptableEventListener<T> listener)
        {
            Listeners -= listener.OnEventInvoked;
        }

        public void Unsubscribe(Action<T> listener)
        {
            Listeners -= listener;
        }
    }

    public abstract class ScriptableEvent<T0, T1> : ScriptableObject
    {
        private event Action<T0, T1> Listeners;

        private void OnDestroy()
        {
            Listeners = null;
        }

        public void Invoke(T0 arg0, T1 arg1)
        {
            Listeners?.Invoke(arg0, arg1);
        }

        public void Clear()
        {
            Listeners = null;
        }

        public void Subscribe(ScriptableEventListener<T0, T1> listener)
        {
            Listeners += listener.OnEventInvoked;
        }

        public void Subscribe(Action<T0, T1> listener)
        {
            Listeners += listener;
        }

        public void Unsubscribe(ScriptableEventListener<T0, T1> listener)
        {
            Listeners -= listener.OnEventInvoked;
        }

        public void Unsubscribe(Action<T0, T1> listener)
        {
            Listeners -= listener;
        }
    }

    public abstract class ScriptableEvent<T0, T1, T2> : ScriptableObject
    {
        private event Action<T0, T1, T2> Listeners;

        private void OnDestroy()
        {
            Listeners = null;
        }

        public void Invoke(T0 arg0, T1 arg1, T2 arg2)
        {
            Listeners?.Invoke(arg0, arg1, arg2);
        }

        public void Clear()
        {
            Listeners = null;
        }

        public void Subscribe(ScriptableEventListener<T0, T1, T2> listener)
        {
            Listeners += listener.OnEventInvoked;
        }

        public void Subscribe(Action<T0, T1, T2> listener)
        {
            Listeners += listener;
        }

        public void Unsubscribe(ScriptableEventListener<T0, T1, T2> listener)
        {
            Listeners -= listener.OnEventInvoked;
        }

        public void Unsubscribe(Action<T0, T1, T2> listener)
        {
            Listeners -= listener;
        }
    }

    public abstract class ScriptableEvent<T0, T1, T2, T3> : ScriptableObject
    {
        private event Action<T0, T1, T2, T3> Listeners;

        private void OnDestroy()
        {
            Listeners = null;
        }

        public void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            Listeners?.Invoke(arg0, arg1, arg2, arg3);
        }

        public void Clear()
        {
            Listeners = null;
        }

        public void Subscribe(ScriptableEventListener<T0, T1, T2, T3> listener)
        {
            Listeners += listener.OnEventInvoked;
        }

        public void Subscribe(Action<T0, T1, T2, T3> listener)
        {
            Listeners += listener;
        }

        public void Unsubscribe(ScriptableEventListener<T0, T1, T2, T3> listener)
        {
            Listeners -= listener.OnEventInvoked;
        }

        public void Unsubscribe(Action<T0, T1, T2, T3> listener)
        {
            Listeners -= listener;
        }
    }
}