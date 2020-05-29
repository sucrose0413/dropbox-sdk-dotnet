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
    /// <para>Team merge request reminder details shown to the secondary team</para>
    /// </summary>
    public class SecondaryTeamRequestReminderDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SecondaryTeamRequestReminderDetails> Encoder = new SecondaryTeamRequestReminderDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SecondaryTeamRequestReminderDetails> Decoder = new SecondaryTeamRequestReminderDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SecondaryTeamRequestReminderDetails" /> class.</para>
        /// </summary>
        /// <param name="sentTo">The email of the primary team admin the request was sent
        /// to.</param>
        public SecondaryTeamRequestReminderDetails(string sentTo)
        {
            if (sentTo == null)
            {
                throw new sys.ArgumentNullException("sentTo");
            }

            this.SentTo = sentTo;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SecondaryTeamRequestReminderDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SecondaryTeamRequestReminderDetails()
        {
        }

        /// <summary>
        /// <para>The email of the primary team admin the request was sent to.</para>
        /// </summary>
        public string SentTo { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SecondaryTeamRequestReminderDetails" />.</para>
        /// </summary>
        private class SecondaryTeamRequestReminderDetailsEncoder : enc.StructEncoder<SecondaryTeamRequestReminderDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SecondaryTeamRequestReminderDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("sent_to", value.SentTo, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SecondaryTeamRequestReminderDetails" />.</para>
        /// </summary>
        private class SecondaryTeamRequestReminderDetailsDecoder : enc.StructDecoder<SecondaryTeamRequestReminderDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="SecondaryTeamRequestReminderDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SecondaryTeamRequestReminderDetails Create()
            {
                return new SecondaryTeamRequestReminderDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SecondaryTeamRequestReminderDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "sent_to":
                        value.SentTo = enc.StringDecoder.Instance.Decode(reader);
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