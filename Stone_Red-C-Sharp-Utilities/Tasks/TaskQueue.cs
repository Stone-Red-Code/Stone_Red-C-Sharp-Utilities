using System;
using System.Collections.Concurrent;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading.Tasks;

namespace Stone_Red_C_Sharp_Utilities.Tasks
{
    /// <summary>
    /// An <see langword="asnyc"/> queue.
    /// </summary>
    public class TaskQueue
    {
        private readonly ConcurrentQueue<(Task Task, Action Callback)> tasks = new ConcurrentQueue<(Task Task, Action Callback)>();
        private bool processing = false;

        /// <inheritdoc cref="ITaskQueue.Enqueue{T}(Func{T})"/>
        public IObservable<Task<T>> Enqueue<T>(Func<T> function)
        {
            Subject<Task<T>> subject = new Subject<Task<T>>();
            Task<T> task = new Task<T>(function);

            tasks.Enqueue((task, () => subject.OnNext(task)));

            ProcessTasks();

            return subject.AsObservable();
        }

        /// <inheritdoc cref="ITaskQueue.Enqueue(Action)"/>
        public IObservable<Task> Enqueue(Action function)
        {
            Subject<Task> subject = new Subject<Task>();
            Task task = new Task(function);

            tasks.Enqueue((task, () => subject.OnNext(task)));

            ProcessTasks();

            return subject.AsObservable();
        }

        /// <inheritdoc cref="ITaskQueue.Enqueue(Task)"/>
        public IObservable<Task> Enqueue(Task task)
        {
            Subject<Task> subject = new Subject<Task>();

            tasks.Enqueue((task, () => subject.OnNext(task)));

            ProcessTasks();

            return subject.AsObservable();
        }

        /// <inheritdoc cref="ITaskQueue.Enqueue{T}(Task{T})"/>
        public IObservable<Task<T>> Enqueue<T>(Task<T> task)
        {
            Subject<Task<T>> subject = new Subject<Task<T>>();

            tasks.Enqueue((task, () => subject.OnNext(task)));

            ProcessTasks();

            return subject.AsObservable();
        }

        private async void ProcessTasks()
        {
            if (processing)
            {
                return;
            }

            processing = true;

            while (tasks.TryDequeue(out (Task Task, Action Callback) container))
            {
                if (container.Task.Status == TaskStatus.Created)
                {
                    container.Task.Start();
                }

                await container.Task;
                container.Callback?.Invoke();
            }
        }
    }
}