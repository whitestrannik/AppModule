﻿using ChipAndDale.SDK.Common;
using Core.SDK.Common;
using Core.SDK.Composite.Service;
using Core.SDK.Composite.UI;
using Core.SDK.Log;

namespace ChipAndDale.Task.Command
{
    internal class TaskListCommand : ICommand
    {
        internal TaskListCommand() 
        {            
            IServiceMgr serviceMgr = ServiceMgr.Current;
            _logMgr = serviceMgr.GetInstance<ILogMgr>();
            _logger = _logMgr.GetLogger("TaskListCommand");
            _commonDbService = serviceMgr.GetInstance<ICommonService>();
            _logger.Debug("Create.");
            _logger.Debug("Interfaces: ICommonDbService = {0};", _commonDbService.ToStateString());
        }

        public void Execute()
        {
            _logger.Debug("Execute");            
        }

        public string Name
        {
            get { return "TaskListCommand"; }
        }

        public string Caption
        {
            get { return "Реєстр завдань"; }
        }

        public string Hint
        {
            get { return "Показати реєстр завдань"; }
        }

        public System.Drawing.Image Image
        {
            get { return Properties.Resources.TaskList; }
        }

        public bool IsVisible
        {
            get { return true; }
        }

        public bool IsEnabled
        {
            get 
            {
                return true;/*_commonDbService.IsConnect*/;
            }
        }

        public bool IsChecked
        {
            get { return false; }
        }

        public bool HasState
        {
            get { return false; }
        }

        public CommandType CommandType
        {
            get { return global::Core.SDK.Composite.UI.CommandType.Button; }
        }

        #region private 
        ILogMgr _logMgr;
        ILogger _logger;        
        ICommonService _commonDbService;
        #endregion private
    }
}
