using System;

namespace MahAppBase
{
	public class ExcutingTask
	{
		#region Property
		/// <summary>
		/// 目前執行項目名稱
		/// </summary>
		public string ItemName { get; set; }

		/// <summary>
		/// 開始時間
		/// </summary>
		public DateTime StartDateTime { get; set; }

		/// <summary>
		/// 結束時間
		/// </summary>
		public DateTime EndDateTime { get; set; }

		/// <summary>
		/// 花費時間
		/// </summary>
		public string CostTime { get; set; }

		/// <summary>
		/// 進度
		/// </summary>
		public string Progress { get; set; }
		#endregion

		#region Memberfunction
		/// <summary>
		/// 建構子
		/// </summary>
		public ExcutingTask() { }
		#endregion

	}
}
