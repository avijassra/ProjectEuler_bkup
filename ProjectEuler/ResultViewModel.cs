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
		/// <param name="description">The description.</param>
		public ResultViewModel(int answer, long timeElapsed, string description = null)
			: this(answer.ToString(), timeElapsed, description)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ResultViewModel"/> class.
		/// </summary>
		/// <param name="answer">The result.</param>
		/// <param name="timeElapsed">The time elapsed.</param>
		/// <param name="description">The description.</param>
		public ResultViewModel(Int64 answer, long timeElapsed, string description = null)
			: this(answer.ToString(), timeElapsed, description)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ResultViewModel"/> class.
		/// </summary>
		/// <param name="answer">The result.</param>
		/// <param name="timeElapsed">The time elapsed.</param>
		/// <param name="description">The description.</param>
		public ResultViewModel(int answer, TimeSpan timeElapsed, string description = null)
			: this(answer.ToString(), timeElapsed.Milliseconds, description)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ResultViewModel"/> class.
		/// </summary>
		/// <param name="answer">The result.</param>
		/// <param name="timeElapsed">The time elapsed.</param>
		/// <param name="description">The description.</param>
		public ResultViewModel(Int64 answer, TimeSpan timeElapsed, string description = null)
			: this(answer.ToString(), timeElapsed.Milliseconds, description)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ResultViewModel"/> class.
		/// </summary>
		/// <param name="answer">The result.</param>
		/// <param name="timeElapsed">The time elapsed.</param>
		/// <param name="description">The description.</param>
		public ResultViewModel(string answer, long timeElapsed, string description = null)
		{
			Description = description;
			Answer = answer;
			TimeElapsed = timeElapsed.ToString();
		}

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>
		/// The description.
		/// </value>
		public string Description { get; set; }

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
