using System;

namespace UMP.DocumentFlow.Dtos
{
    public class DocumentChargeInfoDTO
    {
        public object Id { get; set; }

        public object KindId { get; set; }

        public string KindName { get; set; }

        public string ServiceKindName { get; set; }

        public string ChargeText { get; set; }

        public string PerformerResponse { get; set; }

        public DateTime? TimeFrameStart { get; set; }

        public DateTime? TimeFrameDeadline { get; set; }

        public DateTime? PerformingDateTime { get; set; }

        public bool IsForAcquaitance { get; set; }

        public DocumentChargeAccessRightsDTO AccessRights { get; set; }

        public DocumentFlowEmployeeInfoDTO PerformerInfoDTO { get; set; }

        public DocumentFlowEmployeeInfoDTO ActuallyPerformedEmployeeInfoDTO { get; set; }
    }
}