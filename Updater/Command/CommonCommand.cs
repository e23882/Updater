using System;
using System.Windows.Input;

namespace MahAppBase
{
    /// <summary>
    /// 有參數共用Command
    /// </summary>
    public class CommonCommand : ICommand
    {
        #region Declarations
        private readonly Action<object> _execute;
        public event EventHandler CanExecuteChanged;
        #endregion

        #region Memberfunction
        /// <summary>
        /// 是否可以執行
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// 執行
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="execute"></param>
        public CommonCommand(Action<object> execute)
        {
            _execute = execute;
        }
        #endregion
    }
}