using System;
using System.Threading;
using System.Threading.Tasks;

namespace Stone_Red_C_Sharp_Utilities.Tasks
{
    /// <summary>
    /// An <see langword="asnyc"/> queue.
    /// </summary>
    public class BlockingTaskQueue : ITaskQueue
    {
        private readonly SemaphoreSlim semaphore;

        /// <summary>
        /// Creates a new <see cref="BlockingTaskQueue"/>
        /// </summary>
        public BlockingTaskQueue()
        {
            semaphore = new SemaphoreSlim(1);
        }

        /// <inheritdoc cref="ITaskQueue.Enqueue{T}(Func{T})"/>
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

        /// <inheritdoc cref="ITaskQueue.Enqueue(Action)"/>
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

        /// <inheritdoc cref="ITaskQueue.Enqueue(Task)"/>
        public async Task Enqueue(Task task)
        {
            await semaphore.WaitAsync();
            try
            {
                await task;
            }
            finally
            {
                _ = semaphore.Release();
            }
        }

        /// <inheritdoc cref="ITaskQueue.Enqueue{T}(Task{T})"/>
        public async Task<T> Enqueue<T>(Task<T> task)
        {
            await semaphore.WaitAsync();
            try
            {
                return await task;
            }
            finally
            {
                _ = semaphore.Release();
            }
        }
    }
}