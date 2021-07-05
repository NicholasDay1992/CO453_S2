using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
	public class Post
	{
		// ID of the post
		public int PostId;
		// username of the post's author
		public String Username;
		public DateTime Timestamp;
		public int instances;
		public int likes;
		public List<string> comments;

		public Post()
		{

		}
		///<summary>
		/// Record one more 'Like' indication from a user.
		///</summary>
		public void Like()
		{
			likes++;
		}
		///<summary>
		/// Record that a user has withdrawn his/her 'Like' vote.
		///</summary>
		public void Unlike()
		{
			if (likes > 0)
			{
				likes--;
			}
		}

		///<summary>
		/// Add a comment to this post.
		///</summary>
		/// <param name="text">
		/// The new comment to add.
		/// </param>
		public void AddComment(String text)
		{
			comments.Add(text);
		}
		public void Display()
		{
			Console.WriteLine("Post ID: " + PostId);
			Console.WriteLine($"    Author: {Username}");
			Console.WriteLine($"    Time Elpased: {FormatElapsedTime(Timestamp)}");
			Console.WriteLine();

			if (likes > 0)
			{
				Console.WriteLine($"    Likes:  {likes}  people like this.");
			}
			else
			{
				Console.WriteLine();
			}

			if (comments.Count == 0)
			{
				Console.WriteLine("    No comments.");
			}
			else
			{
				Console.WriteLine($"    {comments.Count}  comment(s). Click here to view.");
			}
		}
		protected String FormatElapsedTime(DateTime time)
		{
			DateTime current = DateTime.Now;
			TimeSpan timePast = current - time;

			long seconds = (long)timePast.TotalSeconds;
			long minutes = seconds / 60;

			if (minutes > 0)
			{
				return minutes + " minutes ago";
			}
			else
			{
				return seconds + " seconds ago";
			}
		}
		public void GetNumberOfPosts()
		{

		}
	}
}
