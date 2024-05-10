using RSM.HCD.CSharp.Core.Constants;
using RSM.HCD.CSharp.Core.Interfaces.Providers.Worker;
using RSM.HCD.CSharp.Core.Models.Entities.Worker;
using System;
using System.Linq.Expressions;

namespace RSM.HCD.CSharp.Core.Providers.Worker
{
    /// <summary>
    /// Base class for implementing common worker functionality
    /// </summary>
    public abstract class WorkerProvider : Provider, IWorkerProvider
    {
        /// <summary>
        /// Deletes a job by its identifier
        /// </summary>
        /// <param name="id">job identifier</param>
        /// <returns>success status</returns>
        public abstract bool Delete(string id);

        /// <summary>
        /// Count of deleted jobs
        /// </summary>
        /// <returns></returns>
        public abstract long DeletedCount();

        /// <summary>
        ///  Create a new fire and forget worker task
        /// </summary>
        /// <param name="methodCall"></param>
        /// <returns></returns>
        public abstract string Enqueue(Expression<Action> methodCall);

        /// <summary>
        ///  Create a new fire and forget worker task
        /// </summary>
        /// <param name="methodCall"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public abstract string Enqueue<T>(Expression<Action<T>> methodCall);

        /// <summary>
        /// Enqueued can still mean deleted. This includes all jobs enqueued regardless of state.
        /// </summary>
        /// <param name="queue"></param>
        /// <returns></returns>
        public abstract long EnqueuedCount(string queue = Queue.DEFAULT);

        // TODO: Not using so commenting out for now to reduce dependencies.
        // public abstract Result<IJobDetails> GetJob(string id);

        // TODO: Not using so commenting out for now to reduce dependencies.
        // public abstract Result<IRecurringJobDetails> GetRecurringJob(string id);


        /// <summary>
        /// Create a recurring worker task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="methodCall"></param>
        /// <param name="recurringOptions"></param>
        public abstract void Recur(string id, Expression<Action> methodCall, RecurringOption recurringOptions);

        /// <summary>
        /// Create a recurring worker task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="methodCall"></param>
        /// <param name="chronExpression"></param>
        /// <typeparam name="T"></typeparam>
        public abstract void Recur<T>(string id, Expression<Action<T>> methodCall, string chronExpression);

        /// <summary>
        /// Create a recurring worker task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="methodCall"></param>
        /// <param name="recurringOptions"></param>
        /// <typeparam name="T"></typeparam>
        public abstract void Recur<T>(string id, Expression<Action<T>> methodCall, RecurringOption recurringOptions);

        /// <summary>
        /// Number of jobs that have been setup for recurrence.
        /// </summary>
        /// <returns></returns>
        public abstract long RecurringCount();

        /// <summary>
        /// Remove a worker recurrence
        /// </summary>
        /// <param name="id"></param>
        public abstract void RemoveRecurrence(string id);

        /// <summary>
        /// Schedule a method to be enqueued at a specific time
        /// </summary>
        /// <param name="methodCall"></param>
        /// <param name="enqueueOn"></param>
        /// <returns></returns>
        public abstract string Schedule(Expression<Action> methodCall, DateTimeOffset enqueueOn);

        /// <summary>
        /// Schedule a method to be enqueued at a specific time
        /// </summary>
        /// <param name="methodCall"></param>
        /// <param name="enqueueOn"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public abstract string Schedule<T>(Expression<Action<T>> methodCall, DateTimeOffset enqueueOn);

        /// <summary>
        /// Schedule a method to be enqueued at a specific time
        /// </summary>
        /// <param name="methodCall"></param>
        /// <param name="delay"></param>
        /// <returns></returns>
        public abstract string Schedule(Expression<Action> methodCall, TimeSpan delay);

        /// <summary>
        /// Schedule a method to be enqueued at a specific time
        /// </summary>
        /// <param name="methodCall"></param>
        /// <param name="delay"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public abstract string Schedule<T>(Expression<Action<T>> methodCall, TimeSpan delay);
    }
}
