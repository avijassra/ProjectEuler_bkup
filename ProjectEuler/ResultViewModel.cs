namespace ProjectEuler
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public class ResultViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultViewModel"/> class.
        /// </summary>
        /// <param name="answer">The result.</param>
        /// <param name="timeElapsed">The time elapsed.</param>
        public ResultViewModel(int answer, long timeElapsed)
        : this(answer.ToString(), timeElapsed)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultViewModel"/> class.
        /// </summary>
        /// <param name="answer">The result.</param>
        /// <param name="timeElapsed">The time elapsed.</param>
        public ResultViewModel(int answer, TimeSpan timeElapsed)
            : this(answer.ToString(), timeElapsed.Milliseconds)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultViewModel"/> class.
        /// </summary>
        /// <param name="answer">The result.</param>
        /// <param name="timeElapsed">The time elapsed.</param>
        public ResultViewModel(string answer, long timeElapsed)
        {
            Answer = answer;
            TimeElapsed = timeElapsed.ToString();
        }

        /// <summary>
        /// Gets or sets the answer.
        /// </summary>
        /// <value>
        /// The answer.
        /// </value>
        public string Answer { get; set; }

        /// <summary>
        /// Gets or sets the elapsed.
        /// </summary>
        /// <value>
        /// The elapsed.
        /// </value>
        public string TimeElapsed { get; set; }
    }
}
