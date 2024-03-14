using System;
using System.Threading.Tasks;

namespace Stone_Red_C_Sharp_Utilities.Tasks
{
    internal interface ITaskQueue
    {
        /// <summary>
        /// Enqueues a <see cref="Func{T}"/>.
        /// </summary>
        /// <typeparam name="T">The return type.</typeparam>
        /// <param name="function">The code to enqueue.</param>
        /// <returns>A <see cref="Task{T}"/> to await</returns>
        public Task<T> Enqueue<T>(Func<T> function);

        /// <summary>
        /// Enqueues an <see cref="Action"/>.
        /// </summary>
        /// <param name="function">The code to enqueue.</param>
        /// <returns>A <see cref="Task{T}"/> to await</returns>
        public Task Enqueue(Action function);

        /// <summary>
        /// Enqueues an <see cref="Task"/>.
        /// </summary>
        /// <param name="task">The code to enqueue.</param>
        /// <returns>A <see cref="Task"/> to await</returns>
        public Task Enqueue(Task task);

        /// <summary>
        /// Enqueues an <see cref="Task"/>.
        /// </summary>
        /// <param name="task">The code to enqueue.</param>
        /// <returns>A <see cref="Task"/> to await</returns>
        public Task<T> Enqueue<T>(Task<T> task);
    }
}
