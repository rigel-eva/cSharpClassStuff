using System;
namespace Application
{
	public class time
	{
		private int second;
		private int minute;
		private int hour;
		public time(int second=0, int minute=0, int hour=0)
		{
			this.second = second;
			this.minute = minute;
			this.hour = hour;
		}
		public override string ToString()
		{
			return string.Format("{0}:{1}:{2}", hour, minute, second);
		}
	}
}
