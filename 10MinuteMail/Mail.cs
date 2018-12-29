using System;

namespace _10MinuteMail
{
    [Serializable]
    public struct Mail
    {
        public string Subject;
        public bool Read;
        public bool Forwarded;
        public bool Expanded;
        public string BodyPreview;
        public string PrimaryFromAddress;
        public int AttachmentCount;
        public string BodyText;
        public string[] RecipientList;
        public string[] FromList;
        public string FormattedDate;
        public string BodyPlainText;
        public long SentDate;
        public bool RepliedTo;
        public string Id;
    }
}
