using System;
using MahApps.Metro.Controls;

namespace MahAppBase.CustomerUserControl
{
	/// <summary>
	/// ShowLogWindow.xaml 的互動邏輯
	/// </summary>
	public partial class ShowLogWindow: MetroWindow
	{
		#region Declarations
		#endregion

		#region Property
		/// <summary>
		/// 顯示執行紀錄的ViewModel
		/// </summary>
		public ShowLogViewModel MainViewModel { get; set; }
		#endregion

		#region Memberfunction
		/// <summary>
		/// 建構子
		/// </summary>
		public ShowLogWindow()
		{
			InitializeComponent();
			MainViewModel = new ShowLogViewModel();
			MainViewModel.ExcuteLogCollection.Add(new ExcuteLog()
			{
				StartDateTime = new DateTime(2023, 11, 24, 12, 52, 00),
				EndDateTime = new DateTime(2023, 11, 24, 12, 53, 00),
				ExcuteDateTime = new DateTime(2023, 11, 24, 12, 50, 00),
				CostTime = "02:00",
				IsSuccess = "Success"

			});
			MainViewModel.ExcuteLogCollection.Add(new ExcuteLog()
			{
				StartDateTime = new DateTime(2023, 11, 24, 12, 55, 00),
				EndDateTime = new DateTime(2023, 11, 24, 12, 58, 00),
				ExcuteDateTime = new DateTime(2023, 11, 24, 12, 54, 00),
				CostTime = "03:00",
				IsSuccess = "Fail"

			});
			this.DataContext = MainViewModel;
		}
		#endregion
	}
}
