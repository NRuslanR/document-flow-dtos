using System;
using System.Collections.Generic;

namespace UMP.DocumentFlow.Dtos
{
    public class DocumentDTO
    {
        public object Id { get; set; }

        public object BaseDocumentId { get; set; }

        public string Number { get; set; }

        public string SeparatorOfNumberParts { get; set; }

        public string Name { get; set; }

        public string FullName { get; set; }

        public string ProductCode { get; set; }

        public string Content { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? DocumentDate { get; set; }

        public string Note { get; set; }

        public string Kind { get; set; }

        public object KindId { get; set; }

        public DocumentFlowEmployeeInfoDTO AuthorDTO { get; set; }

        public IEnumerable<DocumentChargeInfoDTO> ChargesInfoDTO { get; set; }

        public IEnumerable<DocumentApprovingInfoDTO> ApprovingsInfoDTO { get; set; }

        public IEnumerable<DocumentSigningInfoDTO> SigningsInfoDTO { get; set; }

        public DocumentResponsibleInfoDTO ResponsibleInfoDTO { get; set; }

        public int CurrentWorkCycleStageNumber { get; set; }

        public string CurrentWorkCycleStageName { get; set; }

        public bool? IsSelfRegistered { get; set; }
    }
}