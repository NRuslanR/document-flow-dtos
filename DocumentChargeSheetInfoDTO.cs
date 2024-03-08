using System;

namespace UMP.DocumentFlow.Dtos
{
    public class DocumentChargeSheetInfoDTO
    {
        public object Id { get; set; }

        public object KindId { get; set; }

        public string KindName { get; set; }

        public string ServiceKindName { get; set; }

        public object TopLevelChargeSheetId { get; set; }

        public object DocumentId { get; set; }

        public object DocumentKindId { get; set; }

        public DateTime? TimeFrameStart { get; set; }

        public DateTime? TimeFrameDeadline { get; set; }

        public DateTime? IssuingDateTime { get; set; }

        public DateTime? PerformingDateTime { get; set; }

        public bool IsForAcquaitance { get; set; }

        public DateTime? ViewingDateByPerformer { get; set; }


        public DocumentChargeSheetAccessRightsDTO AccessRights { get; set; }

        public DocumentFlowEmployeeInfoDTO PerformerInfoDTO { get; set; }

        public DocumentFlowEmployeeInfoDTO ActuallyPerformedEmployeeInfoDTO { get; set; }

        public DocumentFlowEmployeeInfoDTO IssuerInfoDTO { get; set; }

        public string ChargeText { get; set; }

        public string PerformerResponse { get; set; }
    }
}