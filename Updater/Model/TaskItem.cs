using System;

namespace MahAppBase
{
    public class TaskItem
    {
        /// <summary>
        /// 最後修改時間
        /// </summary>
        public DateTime ModifyDateTime { get; set; }
        
        /// <summary>
        /// Task名稱
        /// </summary>
        public string TaskName { get; set; }
    }
}