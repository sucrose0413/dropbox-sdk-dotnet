// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The member add arg object</para>
    /// </summary>
    public class MemberAddArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MemberAddArg> Encoder = new MemberAddArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MemberAddArg> Decoder = new MemberAddArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MemberAddArg" /> class.</para>
        /// </summary>
        /// <param name="memberEmail">The member email</param>
        /// <param name="memberGivenName">Member's first name.</param>
        /// <param name="memberSurname">Member's last name.</param>
        /// <param name="memberExternalId">External ID for member.</param>
        /// <param name="memberPersistentId">Persistent ID for member. This field is only
        /// available to teams using persistent ID SAML configuration.</param>
        /// <param name="sendWelcomeEmail">Whether to send a welcome email to the member. If
        /// send_welcome_email is false, no email invitation will be sent to the user. This may
        /// be useful for apps using single sign-on (SSO) flows for onboarding that want to
        /// handle announcements themselves.</param>
        /// <param name="role">The role</param>
        /// <param name="isDirectoryRestricted">Whether a user is directory restricted.</param>
        public MemberAddArg(string memberEmail,
                            string memberGivenName = null,
                            string memberSurname = null,
                            string memberExternalId = null,
                            string memberPersistentId = null,
                            bool sendWelcomeEmail = true,
                            AdminTier role = null,
                            bool? isDirectoryRestricted = null)
        {
            if (memberEmail == null)
            {
                throw new sys.ArgumentNullException("memberEmail");
            }
            if (memberEmail.Length > 255)
            {
                throw new sys.ArgumentOutOfRangeException("memberEmail", "Length should be at most 255");
            }
            if (!re.Regex.IsMatch(memberEmail, @"\A(?:^['&A-Za-z0-9._%+-]+@[A-Za-z0-9-][A-Za-z0-9.-]*.[A-Za-z]{2,15}$)\z"))
            {
                throw new sys.ArgumentOutOfRangeException("memberEmail", @"Value should match pattern '\A(?:^['&A-Za-z0-9._%+-]+@[A-Za-z0-9-][A-Za-z0-9.-]*.[A-Za-z]{2,15}$)\z'");
            }

            if (memberGivenName != null)
            {
                if (memberGivenName.Length > 100)
                {
                    throw new sys.ArgumentOutOfRangeException("memberGivenName", "Length should be at most 100");
                }
                if (!re.Regex.IsMatch(memberGivenName, @"\A(?:[^/:?*<>""|]*)\z"))
                {
                    throw new sys.ArgumentOutOfRangeException("memberGivenName", @"Value should match pattern '\A(?:[^/:?*<>""|]*)\z'");
                }
            }

            if (memberSurname != null)
            {
                if (memberSurname.Length > 100)
                {
                    throw new sys.ArgumentOutOfRangeException("memberSurname", "Length should be at most 100");
                }
                if (!re.Regex.IsMatch(memberSurname, @"\A(?:[^/:?*<>""|]*)\z"))
                {
                    throw new sys.ArgumentOutOfRangeException("memberSurname", @"Value should match pattern '\A(?:[^/:?*<>""|]*)\z'");
                }
            }

            if (memberExternalId != null)
            {
                if (memberExternalId.Length > 64)
                {
                    throw new sys.ArgumentOutOfRangeException("memberExternalId", "Length should be at most 64");
                }
            }

            if (role == null)
            {
                role = global::Dropbox.Api.Team.AdminTier.MemberOnly.Instance;
            }
            this.MemberEmail = memberEmail;
            this.MemberGivenName = memberGivenName;
            this.MemberSurname = memberSurname;
            this.MemberExternalId = memberExternalId;
            this.MemberPersistentId = memberPersistentId;
            this.SendWelcomeEmail = sendWelcomeEmail;
            this.Role = role;
            this.IsDirectoryRestricted = isDirectoryRestricted;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MemberAddArg" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public MemberAddArg()
        {
            this.SendWelcomeEmail = true;
            this.Role = global::Dropbox.Api.Team.AdminTier.MemberOnly.Instance;
        }

        /// <summary>
        /// <para>Gets the member email of the member add arg</para>
        /// </summary>
        public string MemberEmail { get; protected set; }

        /// <summary>
        /// <para>Member's first name.</para>
        /// </summary>
        public string MemberGivenName { get; protected set; }

        /// <summary>
        /// <para>Member's last name.</para>
        /// </summary>
        public string MemberSurname { get; protected set; }

        /// <summary>
        /// <para>External ID for member.</para>
        /// </summary>
        public string MemberExternalId { get; protected set; }

        /// <summary>
        /// <para>Persistent ID for member. This field is only available to teams using
        /// persistent ID SAML configuration.</para>
        /// </summary>
        public string MemberPersistentId { get; protected set; }

        /// <summary>
        /// <para>Whether to send a welcome email to the member. If send_welcome_email is
        /// false, no email invitation will be sent to the user. This may be useful for apps
        /// using single sign-on (SSO) flows for onboarding that want to handle announcements
        /// themselves.</para>
        /// </summary>
        public bool SendWelcomeEmail { get; protected set; }

        /// <summary>
        /// <para>Gets the role of the member add arg</para>
        /// </summary>
        public AdminTier Role { get; protected set; }

        /// <summary>
        /// <para>Whether a user is directory restricted.</para>
        /// </summary>
        public bool? IsDirectoryRestricted { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MemberAddArg" />.</para>
        /// </summary>
        private class MemberAddArgEncoder : enc.StructEncoder<MemberAddArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MemberAddArg value, enc.IJsonWriter writer)
            {
                WriteProperty("member_email", value.MemberEmail, writer, enc.StringEncoder.Instance);
                if (value.MemberGivenName != null)
                {
                    WriteProperty("member_given_name", value.MemberGivenName, writer, enc.StringEncoder.Instance);
                }
                if (value.MemberSurname != null)
                {
                    WriteProperty("member_surname", value.MemberSurname, writer, enc.StringEncoder.Instance);
                }
                if (value.MemberExternalId != null)
                {
                    WriteProperty("member_external_id", value.MemberExternalId, writer, enc.StringEncoder.Instance);
                }
                if (value.MemberPersistentId != null)
                {
                    WriteProperty("member_persistent_id", value.MemberPersistentId, writer, enc.StringEncoder.Instance);
                }
                WriteProperty("send_welcome_email", value.SendWelcomeEmail, writer, enc.BooleanEncoder.Instance);
                WriteProperty("role", value.Role, writer, global::Dropbox.Api.Team.AdminTier.Encoder);
                if (value.IsDirectoryRestricted != null)
                {
                    WriteProperty("is_directory_restricted", value.IsDirectoryRestricted.Value, writer, enc.BooleanEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MemberAddArg" />.</para>
        /// </summary>
        private class MemberAddArgDecoder : enc.StructDecoder<MemberAddArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MemberAddArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MemberAddArg Create()
            {
                return new MemberAddArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MemberAddArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "member_email":
                        value.MemberEmail = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "member_given_name":
                        value.MemberGivenName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "member_surname":
                        value.MemberSurname = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "member_external_id":
                        value.MemberExternalId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "member_persistent_id":
                        value.MemberPersistentId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "send_welcome_email":
                        value.SendWelcomeEmail = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "role":
                        value.Role = global::Dropbox.Api.Team.AdminTier.Decoder.Decode(reader);
                        break;
                    case "is_directory_restricted":
                        value.IsDirectoryRestricted = enc.BooleanDecoder.Instance.Decode(reader);
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
