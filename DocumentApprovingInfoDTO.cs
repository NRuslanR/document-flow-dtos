using System;

namespace UMP.DocumentFlow.Dtos
{
    public class DocumentApprovingInfoDTO
    {
        public object Id { get; set; }

        public object TopLevelApprovingId { get; set; }

        public DateTime? PerformingDateTime { get; set; }

        public object PerformingResultId { get; set; }

        public string PerformingResultName { get; set; }

        public bool IsAccessible { get; set; }

        public string Note { get; set; }

        public bool IsViewedByApprover { get; set; }

        public DocumentFlowEmployeeInfoDTO ApproverInfoDTO { get; set; }

        public DocumentFlowEmployeeInfoDTO ActuallyPerformedEmployeeInfoDTO { get; set; }
    }
}