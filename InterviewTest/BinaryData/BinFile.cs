namespace InterviewTest.BinaryData
{
    public class BinFile
    {
        public string Id { get; set; }
        public string Data { get; set; }

        public override bool Equals(object obj)
        {
            BinFile file = obj as BinFile;
            if (file != null)
            {
                return !string.IsNullOrEmpty(file.Id) && file.Data == Data;
            }
            return false;
        }
    }
}
