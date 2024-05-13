namespace RSM.HCD.CSharp.Core.Constants
{
    /// <summary>
    /// Constants class to hold identifiers for a queue concept
    /// </summary>
    public class Queue
    {
        /// <summary>
        /// Easy to access array of all queues in priority order from highest to lowest
        /// </summary>
        public static string[] ALL = { DEFAULT };

        /// <summary>
        /// The default queue, general purpose that should happen relatively soon. Say a few minutes, but the world won't end
        /// if it happens to be delayed.
        /// </summary>
        public const string DEFAULT = "default";
    }
}
