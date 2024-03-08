namespace UMP.DocumentFlow.Dtos
{
    public class DocumentChargeSheetAccessRightsDTO
    {
        public bool? ViewingAllowed { get; set; }

        public bool? ChargeSectionAccessible { get; set; }

        public bool? ResponseSectionAccessible { get; set; }

        public bool? RemovingAllowed { get; set; }

        public bool? PerformingAllowed { get; set; }
    }
}