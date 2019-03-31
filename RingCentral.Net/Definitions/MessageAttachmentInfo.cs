namespace RingCentral
{
    public class MessageAttachmentInfo
    {
        /// <summary>
        /// Internal identifier of a message attachment
        /// </summary>
        public string id;

        /// <summary>
        /// Canonical URI of a message attachment
        /// </summary>
        public string uri;

        /// <summary>
        /// Type of message attachment
        /// Enum: AudioRecording, AudioTranscription, Text, SourceDocument, RenderedDocument, MmsAttachment
        /// </summary>
        public string type;

        /// <summary>
        /// MIME type for a given attachment, for instance 'audio/wav'
        /// </summary>
        public string contentType;

        /// <summary>
        /// Supported for `Voicemail` only. Duration of a voicemail in seconds
        /// </summary>
        public long? vmDuration;

        /// <summary>
        /// Name of a file attached
        /// </summary>
        public string filename;

        /// <summary>
        /// Size of attachment in bytes
        /// </summary>
        public long? size;
    }
}