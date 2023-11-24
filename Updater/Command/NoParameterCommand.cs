using System;
using System.Windows.Input;

namespace MahAppBase
{
    /// <summary>
    /// 無參數共用Command
    /// </summary>
    public class NoParameterCommand : ICommand
    {
        #region Declarations
        public readonly Action _execute = null;
        public event EventHandler CanExecuteChanged;
        #endregion

        #region Memberfunction
        /// <summary>
        /// 是否可以執行動作
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// 執行動作
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _execute.Invoke();
        }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="execute"></param>
        public NoParameterCommand(Action execute)
        {
            _execute = execute;
        }
        #endregion
    }
}