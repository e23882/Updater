using System;
using System.Collections.ObjectModel;

namespace MahAppBase
{
	public  class ShowLogViewModel:ViewModelBase
	{
		#region Declarations
		private ObservableCollection<ExcuteLog> _ExcuteLogCollection;
		#endregion

		#region Property
		/// <summary>
		/// 執行紀錄資料集合
		/// </summary>
		public ObservableCollection<ExcuteLog> ExcuteLogCollection 
		{
			get;set;
		}
		#endregion

		#region Memberfunction
		/// <summary>
		/// 建構子
		/// </summary>
		public ShowLogViewModel() 
		{
			InitialDataSource();
		}

		/// <summary>
		/// 初始化資料集
		/// </summary>
		private void InitialDataSource()
		{
			try
			{
				ExcuteLogCollection = new ObservableCollection<ExcuteLog>();
			}
			catch(Exception ex) 
			{
				/*TODO : 紀錄發生例外的錯誤訊息到log*/
			}
		}
		#endregion
	}
}
