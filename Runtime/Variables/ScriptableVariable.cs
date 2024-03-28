using UnityEngine;
using SH.SOArchitecture.Events;

namespace SH.SOArchitecture.Variables
{
    public abstract class ScriptableVariable<T> : ScriptableEvent<T>
    {
        [SerializeField] private T _startValue;
        private T _value;
        private bool _isInitialized = false;

        public T Value
        {
            get
            {
                if (_isInitialized)
                {
                    return _value;
                }
                _value = _startValue;
                _isInitialized = true;
                Invoke(_value);
                return _value;
            }
            set
            {
                _value = value;
                _isInitialized = true;
                Invoke(_value);
            }
        }

        public override string ToString()
        {
            return $"{nameof(ScriptableVariable<T>)} : {Value}";
        }
    }

    public abstract class ScriptableVariable<T0, T1> : ScriptableEvent<T0, T1>
    {
        [SerializeField] private T0 _startValue0;
        [SerializeField] private T1 _startValue1;
        private T0 _value0;
        private T1 _value1;
        private bool _isInitialized = false;

        public T0 Value0
        {
            get
            {
                if (_isInitialized)
                {
                    return _value0;
                }
                _value0 = _startValue0;
                _value1 = _startValue1;
                _isInitialized = true;
                Invoke(_value0, _value1);
                return _value0;
            }
            set
            {
                _value0 = value;
                _isInitialized = true;
                Invoke(_value0, _value1);
            }
        }

        public T1 Value1
        {
            get
            {
                if (_isInitialized)
                {
                    return _value1;
                }
                _value0 = _startValue0;
                _value1 = _startValue1;
                _isInitialized = true;
                Invoke(_value0, _value1);
                return _value1;
            }
            set
            {
                _value1 = value;
                _isInitialized = true;
                Invoke(_value0, _value1);
            }
        }

        public override string ToString()
        {
            return $"{nameof(ScriptableVariable<T0, T1>)} : {Value0}, {Value1}";
        }
    }

    public abstract class ScriptableVariable<T0, T1, T2> : ScriptableEvent<T0, T1, T2>
    {
        [SerializeField] private T0 _startValue0;
        [SerializeField] private T1 _startValue1;
        [SerializeField] private T2 _startValue2;
        private T0 _value0;
        private T1 _value1;
        private T2 _value2;
        private bool _isInitialized = false;

        public T0 Value0
        {
            get
            {
                if (_isInitialized)
                {
                    return _value0;
                }
                _value0 = _startValue0;
                _value1 = _startValue1;
                _value2 = _startValue2;
                _isInitialized = true;
                Invoke(_value0, _value1, _value2);
                return _value0;
            }
            set
            {
                _value0 = value;
                _isInitialized = true;
                Invoke(_value0, _value1, _value2);
            }
        }

        public T1 Value1
        {
            get
            {
                if (_isInitialized)
                {
                    return _value1;
                }
                _value0 = _startValue0;
                _value1 = _startValue1;
                _value2 = _startValue2;
                _isInitialized = true;
                Invoke(_value0, _value1, _value2);
                return _value1;
            }
            set
            {
                _value1 = value;
                _isInitialized = true;
                Invoke(_value0, _value1, _value2);
            }
        }

        public T2 Value2
        {
            get
            {
                if (_isInitialized)
                {
                    return _value2;
                }
                _value0 = _startValue0;
                _value1 = _startValue1;
                _value2 = _startValue2;
                _isInitialized = true;
                Invoke(_value0, _value1, _value2);
                return _value2;
            }
            set
            {
                _value2 = value;
                _isInitialized = true;
                Invoke(_value0, _value1, _value2);
            }
        }

        public override string ToString()
        {
            return $"{nameof(ScriptableVariable<T0, T1, T2>)} : {Value0}, {Value1}, {Value2}";
        }
    }

    public abstract class ScriptableVariable<T0, T1, T2, T3> : ScriptableEvent<T0, T1, T2, T3>
    {
        [SerializeField] private T0 _startValue0;
        [SerializeField] private T1 _startValue1;
        [SerializeField] private T2 _startValue2;
        [SerializeField] private T3 _startValue3;
        private T0 _value0;
        private T1 _value1;
        private T2 _value2;
        private T3 _value3;
        private bool _isInitialized = false;

        public T0 Value0
        {
            get
            {
                if (_isInitialized)
                {
                    return _value0;
                }
                _value0 = _startValue0;
                _value1 = _startValue1;
                _value2 = _startValue2;
                _value3 = _startValue3;
                _isInitialized = true;
                Invoke(_value0, _value1, _value2, _value3);
                return _value0;
            }
            set
            {
                _value0 = value;
                _isInitialized = true;
                Invoke(_value0, _value1, _value2, _value3);
            }
        }

        public T1 Value1
        {
            get
            {
                if (_isInitialized)
                {
                    return _value1;
                }
                _value0 = _startValue0;
                _value1 = _startValue1;
                _value2 = _startValue2;
                _value3 = _startValue3;
                _isInitialized = true;
                Invoke(_value0, _value1, _value2, _value3);
                return _value1;
            }
            set
            {
                _value1 = value;
                _isInitialized = true;
                Invoke(_value0, _value1, _value2, _value3);
            }
        }

        public T2 Value2
        {
            get
            {
                if (_isInitialized)
                {
                    return _value2;
                }
                _value0 = _startValue0;
                _value1 = _startValue1;
                _value2 = _startValue2;
                _value3 = _startValue3;
                _isInitialized = true;
                Invoke(_value0, _value1, _value2, _value3);
                return _value2;
            }
            set
            {
                _value2 = value;
                _isInitialized = true;
                Invoke(_value0, _value1, _value2, _value3);
            }
        }

        public T3 Value3
        {
            get
            {
                if (_isInitialized)
                {
                    return _value3;
                }
                _value0 = _startValue0;
                _value1 = _startValue1;
                _value2 = _startValue2;
                _value3 = _startValue3;
                _isInitialized = true;
                Invoke(_value0, _value1, _value2, _value3);
                return _value3;
            }
            set
            {
                _value3 = value;
                _isInitialized = true;
                Invoke(_value0, _value1, _value2, _value3);
            }
        }

        public override string ToString()
        {
            return $"{nameof(ScriptableVariable<T0, T1, T2, T3>)} : {Value0}, {Value1}, {Value2}, {Value3}";
        }
    }
}