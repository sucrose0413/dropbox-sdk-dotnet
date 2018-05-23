// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Enabled/disabled downloading files from Dropbox Showcase for team.</para>
    /// </summary>
    public class ShowcaseChangeDownloadPolicyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ShowcaseChangeDownloadPolicyDetails> Encoder = new ShowcaseChangeDownloadPolicyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ShowcaseChangeDownloadPolicyDetails> Decoder = new ShowcaseChangeDownloadPolicyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="ShowcaseChangeDownloadPolicyDetails" /> class.</para>
        /// </summary>
        /// <param name="newValue">New Dropbox Showcase download policy.</param>
        /// <param name="previousValue">Previous Dropbox Showcase download policy.</param>
        public ShowcaseChangeDownloadPolicyDetails(ShowcaseDownloadPolicy newValue,
                                                   ShowcaseDownloadPolicy previousValue)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            if (previousValue == null)
            {
                throw new sys.ArgumentNullException("previousValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="ShowcaseChangeDownloadPolicyDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public ShowcaseChangeDownloadPolicyDetails()
        {
        }

        /// <summary>
        /// <para>New Dropbox Showcase download policy.</para>
        /// </summary>
        public ShowcaseDownloadPolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous Dropbox Showcase download policy.</para>
        /// </summary>
        public ShowcaseDownloadPolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ShowcaseChangeDownloadPolicyDetails" />.</para>
        /// </summary>
        private class ShowcaseChangeDownloadPolicyDetailsEncoder : enc.StructEncoder<ShowcaseChangeDownloadPolicyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ShowcaseChangeDownloadPolicyDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.ShowcaseDownloadPolicy.Encoder);
                WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.ShowcaseDownloadPolicy.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ShowcaseChangeDownloadPolicyDetails" />.</para>
        /// </summary>
        private class ShowcaseChangeDownloadPolicyDetailsDecoder : enc.StructDecoder<ShowcaseChangeDownloadPolicyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="ShowcaseChangeDownloadPolicyDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ShowcaseChangeDownloadPolicyDetails Create()
            {
                return new ShowcaseChangeDownloadPolicyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ShowcaseChangeDownloadPolicyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.ShowcaseDownloadPolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.ShowcaseDownloadPolicy.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
