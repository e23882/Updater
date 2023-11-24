using System;

namespace MahAppBase
{
	public class ExcuteLog
	{
		#region Property
		/// <summary>
		/// 執行時間
		/// </summary>
		public DateTime ExcuteDateTime { get; set; } = DateTime.Now;

		/// <summary>
		/// 開始時間
		/// </summary>
		public DateTime StartDateTime { get; set; } = DateTime.Now;

		/// <summary>
		/// 結束時間
		/// </summary>
		public DateTime EndDateTime { get; set; } = DateTime.Now;

		/// <summary>
		/// 花費時間
		/// </summary>
		public string CostTime { get; set; } = "03:00";

		/// <summary>
		/// 異動項目數量
		/// </summary>
		public int ModifyItemCount { get; set; } = 100;

		/// <summary>
		/// 是否正常
		/// </summary>
		public string IsSuccess { get; set; } = "Success";
		#endregion

		#region Memberfunction
		/// <summary>
		/// 建構子
		/// </summary>
		public ExcuteLog() { }
		#endregion
	}
}
