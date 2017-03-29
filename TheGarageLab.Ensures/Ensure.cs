namespace TheGarageLab.Ensures
{
    using System;

    /// <summary>
    /// Various tests for parameter values.
    /// 
    /// These helpers simplify the process of checking parameters values. Each provides
    /// a generic form that can raise any specified exception as well as a version that
    /// just raises an ArgumentException (most common use case)
    /// </summary>
    public static class Ensure
    {
        /// <summary>
        /// Throw an exception of type T if any of the parameters is not null
        /// </summary>
        /// <typeparam name="T">The exception to throw if the test fails.</typeparam>
        /// <param name="targets">The target values to test</param>
        public static void IsNull<T>(object targets) where T : Exception, new()
        {
            if (targets != null)
                throw new T();
        }

        /// <summary>
        /// Throw an ArgumentException if any parameter is not null
        /// </summary>
        /// <param name="targets">The target values to test</param>
        public static void IsNull(object targets)
        {
            IsNull<ArgumentException>(targets);
        }

        /// <summary>
        /// Throw an exception of type T if any of the parameters is null
        /// </summary>
        /// <typeparam name="T">The exception to throw if the test fails.</typeparam>
        /// <param name="targets">The target values to test</param>
        public static void IsNotNull<T>(object targets) where T : Exception, new()
        {
            if (targets == null)
                throw new T();
        }

        /// <summary>
        /// Throw an ArgumentException if any parameter is null
        /// </summary>
        /// <param name="targets">The target values to test</param>
        public static void IsNotNull(object targets)
        {
            IsNotNull<ArgumentException>(targets);
        }

        /// <summary>
        /// Throw an exception of type T if any of the parameters is not true
        /// </summary>
        /// <typeparam name="T">The exception to throw if the test fails.</typeparam>
        /// <param name="targets">The target values to test</param>
        public static void IsTrue<T>(bool targets) where T : Exception, new()
        {
            if (!targets)
                throw new T();
        }

        /// <summary>
        /// Throw an ArgumentException if any of the parameters is not true
        /// </summary>
        /// <param name="targets">The target values to test</param>
        public static void IsTrue(bool targets)
        {
            IsTrue<ArgumentException>(targets);
        }

        /// <summary>
        /// Throw an exception of type T if any of the parameters is not false
        /// </summary>
        /// <typeparam name="T">The exception to throw if the test fails.</typeparam>
        /// <param name="targets">The target values to test</param>
        public static void IsFalse<T>(bool targets) where T : Exception, new()
        {
            if (targets)
                throw new T();
        }

        /// <summary>
        /// Throw an ArgumentException if any of the parameters is not false
        /// </summary>
        /// <param name="targets">The target values to test</param>
        public static void IsFalse(bool targets)
        {
            IsFalse<ArgumentException>(targets);
        }

        /// <summary>
        /// Throw an exception of type T if any of the string parameters is not an empty string or null
        /// </summary>
        /// <typeparam name="T">The exception to throw if the test fails.</typeparam>
        /// <param name="targets">The target values to test</param>
        public static void IsNullOrEmpty<T>(string targets) where T : Exception, new()
        {
            if (!string.IsNullOrEmpty(targets))
                throw new T();
        }

        /// <summary>
        /// Throw an ArgumentException if any of the string parameters is not an empty string or null
        /// </summary>
        /// <param name="targets">The target values to test</param>
        public static void IsNullOrEmpty(string targets)
        {
            IsNullOrEmpty<ArgumentException>(targets);
        }

        /// <summary>
        /// Throw an exception of type T if any of the string parameters is empty or null.
        /// </summary>
        /// <typeparam name="T">The exception to throw if the test fails.</typeparam>
        /// <param name="targets">The target values to test</param>
        public static void IsNotNullOrEmpty<T>(string targets) where T : Exception, new()
        {
            if (string.IsNullOrEmpty(targets))
                throw new T();
        }

        /// <summary>
        /// Throw an ArgumentException if any of the string parameters is empty or null.
        /// </summary>
        /// <param name="targets">The target values to test</param>
        public static void IsNotNullOrEmpty(string targets)
        {
            IsNotNullOrEmpty<ArgumentException>(targets);
        }

        /// <summary>
        /// Throw an exception of type T if any of the string parameters is not null or doesn't contain only white space
        /// </summary>
        /// <typeparam name="T">The exception to throw if the test fails.</typeparam>
        /// <param name="targets">The target values to test</param>
        public static void IsNullOrWhiteSpace<T>(string targets) where T : Exception, new()
        {
            if (!string.IsNullOrWhiteSpace(targets))
                throw new T();
        }

        /// <summary>
        /// Throw an ArgumentException if any of the string parameters is not null or doesn't contain only white space
        /// </summary>
        /// <param name="targets">The target values to test</param>
        public static void IsNullOrWhiteSpace(string targets)
        {
            IsNullOrWhiteSpace<ArgumentException>(targets);
        }

        /// <summary>
        /// Throw an exception of type T if any of the string parameters is null or contains only white space
        /// </summary>
        /// <typeparam name="T">The exception to throw if the test fails.</typeparam>
        /// <param name="targets">The target values to test</param>
        public static void IsNotNullOrWhiteSpace<T>(string targets) where T : Exception, new()
        {
            if (string.IsNullOrWhiteSpace(targets))
                throw new T();
        }

        /// <summary>
        /// Throw an ArgumentException if any of the string parameters is null or contains only white space
        /// </summary>
        /// <param name="targets">The target values to test</param>
        public static void IsNotNullOrWhiteSpace(string targets)
        {
            IsNotNullOrWhiteSpace<ArgumentException>(targets);
        }
    }
}