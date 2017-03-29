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
        /// Throw an exception of type T if any of the parameters is null
        /// </summary>
        /// <typeparam name="T">The exception to throw if the test fails.</typeparam>
        /// <param name="targets">The target values to test</param>
        public static void IsNotNull<T>(params object[] targets) where T : Exception, new()
        {
            foreach (var obj in targets)
                if (obj == null)
                    throw new T();
        }

        /// <summary>
        /// Throw an ArgumentException if any parameter is null
        /// </summary>
        /// <param name="targets">The target values to test</param>
        public static void IsNotNull(params object[] targets)
        {
            IsNotNull<ArgumentException>(targets);
        }

        /// <summary>
        /// Throw an exception of type T if any of the parameters is not true
        /// </summary>
        /// <typeparam name="T">The exception to throw if the test fails.</typeparam>
        /// <param name="targets">The target values to test</param>
        public static void IsTrue<T>(params bool[] targets) where T : Exception, new()
        {
            foreach (var condition in targets)
                if (!condition)
                    throw new T();
        }

        /// <summary>
        /// Throw an ArgumentException if any of the parameters is not true
        /// </summary>
        /// <param name="targets">The target values to test</param>
        public static void IsTrue(params bool[] targets)
        {
            IsTrue<ArgumentException>(targets);
        }

        /// <summary>
        /// Throw an exception of type T if any of the parameters is not false
        /// </summary>
        /// <typeparam name="T">The exception to throw if the test fails.</typeparam>
        /// <param name="targets">The target values to test</param>
        public static void IsFalse<T>(params bool[] targets) where T : Exception, new()
        {
            foreach (var condition in targets)
                if (condition)
                    throw new T();
        }

        /// <summary>
        /// Throw an ArgumentException if any of the parameters is not false
        /// </summary>
        /// <param name="targets">The target values to test</param>
        public static void IsFalse(params bool[] targets)
        {
            IsFalse<ArgumentException>(targets);
        }

        /// <summary>
        /// Throw an exception of type T if any of the string parameters is not an empty string or null
        /// </summary>
        /// <typeparam name="T">The exception to throw if the test fails.</typeparam>
        /// <param name="targets">The target values to test</param>
        public static void IsNullOrEmpty<T>(params string[] targets) where T : Exception, new()
        {
            foreach (var value in targets)
                if (!string.IsNullOrEmpty(value))
                    throw new T();
        }

        /// <summary>
        /// Throw an ArgumentException if any of the string parameters is not an empty string or null
        /// </summary>
        /// <param name="targets">The target values to test</param>
        public static void IsNullOrEmpty(params string[] targets)
        {
            IsNullOrEmpty<ArgumentException>(targets);
        }

        /// <summary>
        /// Throw an exception of type T if any of the string parameters is empty or null.
        /// </summary>
        /// <typeparam name="T">The exception to throw if the test fails.</typeparam>
        /// <param name="targets">The target values to test</param>
        public static void IsNotNullOrEmpty<T>(params string[] targets) where T : Exception, new()
        {
            foreach (var value in targets)
                if (string.IsNullOrEmpty(value))
                    throw new T();
        }

        /// <summary>
        /// Throw an ArgumentException if any of the string parameters is empty or null.
        /// </summary>
        /// <param name="targets">The target values to test</param>
        public static void IsNotNullOrEmpty(params string[] targets)
        {
            IsNotNullOrEmpty<ArgumentException>(targets);
        }

        /// <summary>
        /// Throw an exception of type T if any of the string parameters is not null or doesn't contain only white space
        /// </summary>
        /// <typeparam name="T">The exception to throw if the test fails.</typeparam>
        /// <param name="targets">The target values to test</param>
        public static void IsNullOrWhiteSpace<T>(params string[] targets) where T : Exception, new()
        {
            foreach (var value in targets)
                if (!string.IsNullOrWhiteSpace(value))
                    throw new T();
        }

        /// <summary>
        /// Throw an ArgumentException if any of the string parameters is not null or doesn't contain only white space
        /// </summary>
        /// <param name="targets">The target values to test</param>
        public static void IsNullOrWhiteSpace(params string[] targets)
        {
            IsNullOrWhiteSpace<ArgumentException>(targets);
        }

        /// <summary>
        /// Throw an exception of type T if any of the string parameters is null or contains only white space
        /// </summary>
        /// <typeparam name="T">The exception to throw if the test fails.</typeparam>
        /// <param name="targets">The target values to test</param>
        public static void IsNotNullOrWhiteSpace<T>(params string[] targets) where T : Exception, new()
        {
            foreach (var value in targets)
                if (string.IsNullOrWhiteSpace(value))
                    throw new T();
        }

        /// <summary>
        /// Throw an ArgumentException if any of the string parameters is null or contains only white space
        /// </summary>
        /// <param name="targets">The target values to test</param>
        public static void IsNotNullOrWhiteSpace(params string[] targets)
        {
            IsNotNullOrWhiteSpace<ArgumentException>(targets);
        }
    }
}