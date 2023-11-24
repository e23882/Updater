using System;
using System.Collections.ObjectModel;
using System.Windows;
using MahAppBase.CustomerUserControl;

namespace MahAppBase
{
    public class MainComponent:ViewModelBase
    {
		#region Declarations
		private bool _FlyOutExcutingIsOpen = false;
		ucDonate donate = new ucDonate();

        #endregion

        #region Property

        /// <summary>
        /// 所有可執行項目
        /// </summary>
        public ObservableCollection<TaskItem> TaskItemSource { get; set; }

        public ObservableCollection<ExcutingTask> CurrentExcuteTask { get; set; }

		/// <summary>
		/// Donate按鈕click command
		/// </summary>
		public NoParameterCommand ButtonDonateClick { get; set; }

        /// <summary>
        /// 執行task command
        /// </summary>
        public CommonCommand TaskExcutingCommand { get; set; }

        public CommonCommand ShowTaskLogCommand { get; set; }

        /// <summary>
        /// donate視窗是否已經顯示
        /// </summary>
        public bool DonateIsOpen { get; set; } = false;

        /// <summary>
        /// 顯示執行歷程視窗物件實例
        /// </summary>
		public ShowLogWindow ShowLogWindow { get; set; }

		/// <summary>
		/// 顯示歷程視窗是否開啟
		/// </summary>
		public bool ShowTaskLogIsOpen { get; set; } = false;

        /// <summary>
        /// 執行命令flyout是否打開
        /// </summary>
        public bool FlyOutExcutingIsOpen
        {
            get
            {
                return _FlyOutExcutingIsOpen;
            }
            set
            {
                _FlyOutExcutingIsOpen = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region MemberFunction

        /// <summary>
        /// 建構子
        /// </summary>
        public MainComponent()
        {
            ButtonDonateClick = new NoParameterCommand(ButtonDonateClickAction);
            InitialDataSource();
            InitialCommand();
        }

        /// <summary>
        /// 初始化命令
        /// </summary>
		private void InitialCommand()
		{
            try
            {
                TaskExcutingCommand = new CommonCommand(TaskExcutingCommandAction);
                ShowTaskLogCommand = new CommonCommand(ShowTaskLogCommandAction);
			}
            catch(Exception ex) 
            {
                /*紀錄錯誤訊息到log*/
            }
		}

		private void ShowTaskLogCommandAction(object obj)
		{
            try
            {
				var currentTaskName = obj.ToString();
				if (string.IsNullOrEmpty(currentTaskName))
				{
					return;
				}
                if(ShowTaskLogIsOpen != true)
                {
					ShowLogWindow = new ShowLogWindow();
                    ShowTaskLogIsOpen = true;
					ShowLogWindow.Closed += ShowLogWindow_Closed;
                    ShowLogWindow.Show();
				}
                else
                {
                    MessageBox.Show("視窗已開啟，請關閉目前開始的視窗。");
                }
				
			}
            catch(Exception ex) 
            {
                /*紀錄錯誤訊息到log*/
            }
		}

		private void ShowLogWindow_Closed(object sender, EventArgs e)
		{
            ShowTaskLogIsOpen = false;
		}

		/// <summary>
		/// 執行task動作
		/// </summary>
		/// <param name="obj"></param>
		private void TaskExcutingCommandAction(object obj)
		{
            try
            {
				var currentTaskName = obj.ToString();
				if (string.IsNullOrEmpty(currentTaskName))
				{
					return;
				}
                FlyOutExcutingIsOpen = true;
                
			}
            catch(Exception ex)
            {
                /*TODO : 紀錄錯誤訊息到log*/
            }
		}

		/// <summary>
		/// 初始化所有資料集合
		/// </summary>
		private void InitialDataSource()
        {
            try
            {
                TaskItemSource = new ObservableCollection<TaskItem>();
                /*mock 資料測試介面*/
                TaskItemSource.Add(new TaskItem()
                {
                    ModifyDateTime = DateTime.Now,
                    TaskName ="部屬FCS正式環境"
                });
                TaskItemSource.Add(new TaskItem()
                {
                    ModifyDateTime = DateTime.Now,
                    TaskName ="部屬FCS測試環境"
                });
                TaskItemSource.Add(new TaskItem()
                {
                    ModifyDateTime = DateTime.Now,
                    TaskName ="部屬FSN正式環境"
                });
                TaskItemSource.Add(new TaskItem()
                {
                    ModifyDateTime = DateTime.Now,
                    TaskName ="部屬FBD測試環境"
                });
                /*TODO : 呼叫資料庫 取得實際的資料 驗證欄位對應是否有錯誤*/
                CurrentExcuteTask = new ObservableCollection<ExcutingTask>();
                CurrentExcuteTask.Add(new ExcutingTask()
                {
                    ItemName = "關閉服務",
                    StartDateTime = new DateTime(1911, 1, 1),
                    EndDateTime = new DateTime(1911, 1, 1),
                    CostTime = "0",
                    Progress = "0/0"
                });
				CurrentExcuteTask.Add(new ExcutingTask()
				{
					ItemName = "備份",
					StartDateTime = new DateTime(1911, 1, 1),
					EndDateTime = new DateTime(1911, 1, 1),
					CostTime = "0",
					Progress = "0/0"
				});
				CurrentExcuteTask.Add(new ExcutingTask()
				{
					ItemName = "部屬",
					StartDateTime = new DateTime(1911, 1, 1),
					EndDateTime = new DateTime(1911, 1, 1),
					CostTime = "0",
					Progress = "0/0"
				});
				CurrentExcuteTask.Add(new ExcutingTask()
				{
					ItemName = "啟動服務",
					StartDateTime = new DateTime(1911, 1, 1),
					EndDateTime = new DateTime(1911, 1, 1),
					CostTime = "0",
					Progress = "0/0"
				});

			}
            catch (Exception ex)
            {
                /*紀錄錯誤訊息*/
            }
        }

        /// <summary>
        /// donate按鈕click動作
        /// </summary>
        public void ButtonDonateClickAction()
        {
            try
            {
				if (!DonateIsOpen)
				{
					donate = new ucDonate
					{
						Topmost = true
					};
					donate.Closed += Donate_Closed;
					DonateIsOpen = true;
					donate.Show();
				}
			}
            catch(Exception ex) 
            {
                /*紀錄錯誤訊息*/
            }
            
        }

        /// <summary>
        /// hook donate視窗關閉事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Donate_Closed(object sender, EventArgs e)
        {
            try
            {
				DonateIsOpen = false;
			}
            catch(Exception ex)
            {
                /*紀錄錯誤訊息*/
            }
        }
        #endregion
    }
}