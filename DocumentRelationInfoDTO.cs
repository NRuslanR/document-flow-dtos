using System;

namespace UMP.DocumentFlow.Dtos
{
    public class DocumentRelationInfoDTO
    {
        public object TargetDocumentId { get; set; }

        public object RelatedDocumentId { get; set; }

        public object RelatedDocumentKindId { get; set; }

        public string RelatedDocumentKindName { get; set; }

        public string RelatedDocumentNumber { get; set; }

        public string RelatedDocumentName { get; set; }

        public DateTime RelatedDocumentDate { get; set; }
    }
}