using System.Collections.Generic;

namespace ReceiveMonitoringDataServer.Models
{
    public abstract class EntityBase<TId>
    {
        IList<string> _brokenRules = new List<string>();

        TId _id;

        public EntityBase() { }

        public EntityBase(TId id)
        {
            Id = id;
        }

        public TId Id
        {
            get;set;
        }

        public bool IsValid()
        {
            ClearCollectionofBrokenRules();
            CheckForBrokenRules();
            return _brokenRules.Count == 0;
        }

        /// <summary>
        /// 检查是否违反模型业务规则
        /// </summary>
        protected virtual void CheckForBrokenRules() { }

        void ClearCollectionofBrokenRules()
        {
            _brokenRules.Clear();
        }


    }
}
