namespace Ghostly.Domain
{
    public sealed class NewRuleModel
    {
        public string Name { get; set; }
        public string Identifier { get; set; }
        public string Expression { get; set; }
        public bool Star { get; set; }
        public bool Mute { get; set; }
        public bool MarkAsRead { get; set; }
        public bool StopProcessing { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryIdentifier { get; set; }
        public string ImportedFrom { get; set; }
    }
}
