// <auto-generated /> Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector.Teams.Models
{
    using System.Linq;

    /// <summary>
    /// Compose extension attachment.
    /// </summary>
    public partial class ComposeExtensionAttachment : Attachment
    {
        /// <summary>
        /// Initializes a new instance of the ComposeExtensionAttachment class.
        /// </summary>
        public ComposeExtensionAttachment() { }

        /// <summary>
        /// Initializes a new instance of the ComposeExtensionAttachment class.
        /// </summary>
        /// <param name="contentType">mimetype/Contenttype for the file</param>
        /// <param name="contentUrl">Content Url</param>
        /// <param name="content">Embedded content</param>
        /// <param name="name">(OPTIONAL) The name of the attachment</param>
        /// <param name="thumbnailUrl">(OPTIONAL) Thumbnail associated with
        /// attachment</param>
        public ComposeExtensionAttachment(string contentType = default(string), string contentUrl = default(string), object content = default(object), string name = default(string), string thumbnailUrl = default(string), Attachment preview = default(Attachment))
            : base(contentType, contentUrl, content, name, thumbnailUrl)
        {
            Preview = preview;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "preview")]
        public Attachment Preview { get; set; }

    }
}
