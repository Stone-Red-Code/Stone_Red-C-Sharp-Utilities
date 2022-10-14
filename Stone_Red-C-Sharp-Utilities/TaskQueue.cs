using System;
using System.Threading;
using System.Threading.Tasks;

namespace Stone_Red_C_Sharp_Utilities
{
    /// <summary>
    /// An <see langword="asnyc"/> queue.
    /// </summary>
    public class TaskQueue
    {
        private readonly SemaphoreSlim semaphore;

        /// <summary>
        /// Creates a new <see cref="TaskQueue"/>
        /// </summary>
        public TaskQueue()
        {
            semaphore = new SemaphoreSlim(1);
        }

        /// <summary>
        /// Enqueues a <see cref="Func{T}"/>.
        /// </summary>
        /// <typeparam name="T">The return type.</typeparam>
        /// <param name="function">The code to enqueue.</param>
        /// <returns>A <see cref="Task{T}"/> to await</returns>
        public async Task<T> Enqueue<T>(Func<T> function)
        {
            await semaphore.WaitAsync();
            try
            {
                return await Task.Run(function);
            }
            finally
            {
                _ = semaphore.Release();
            }
        }

        /// <summary>
        /// Enqueues an <see cref="Action"/>.
        /// </summary>
        /// <param name="function">The code to enqueue.</param>
        /// <returns>A <see cref="Task{T}"/> to await</returns>
        public async Task Enqueue(Action function)
        {
            await semaphore.WaitAsync();
            try
            {
                await Task.Run(function);
            }
            finally
            {
                _ = semaphore.Release();
            }
        }
    }
}