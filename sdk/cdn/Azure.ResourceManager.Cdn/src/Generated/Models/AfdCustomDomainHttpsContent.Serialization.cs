// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class AfdCustomDomainHttpsContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("certificateType");
            writer.WriteStringValue(CertificateType.ToString());
            if (Optional.IsDefined(MinimumTlsVersion))
            {
                writer.WritePropertyName("minimumTlsVersion");
                writer.WriteStringValue(MinimumTlsVersion.Value.ToSerialString());
            }
            if (Optional.IsDefined(Secret))
            {
                if (Secret != null)
                {
                    writer.WritePropertyName("secret");
                    writer.WriteObjectValue(Secret);
                }
                else
                {
                    writer.WriteNull("secret");
                }
            }
            writer.WriteEndObject();
        }

        internal static AfdCustomDomainHttpsContent DeserializeAfdCustomDomainHttpsContent(JsonElement element)
        {
            AfdCertificateType certificateType = default;
            Optional<AfdMinimumTlsVersion> minimumTlsVersion = default;
            Optional<AfdCustomDomainHttpsContentSecret> secret = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateType"))
                {
                    certificateType = new AfdCertificateType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("minimumTlsVersion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minimumTlsVersion = property.Value.GetString().ToAfdMinimumTlsVersion();
                    continue;
                }
                if (property.NameEquals("secret"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        secret = null;
                        continue;
                    }
                    secret = AfdCustomDomainHttpsContentSecret.DeserializeAfdCustomDomainHttpsContentSecret(property.Value);
                    continue;
                }
            }
            return new AfdCustomDomainHttpsContent(certificateType, Optional.ToNullable(minimumTlsVersion), secret.Value);
        }
    }
}
