/*
* Copyright 2007 ZXing authors
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.Text;

namespace zxingwp7.client.result
{
    /// <author>  Sean Owen
    /// </author>
    /// <author>www.Redivivus.in (suraj.supekar@redivivus.in) - Ported from ZXING Java Source 
    /// </author>
    public sealed class AddressBookParsedResult : ParsedResult
    {
        private readonly String[] addresses;
        private readonly String birthday;
        private readonly String[] emails;
        private readonly String[] names;
        private readonly String note;
        private readonly String org;
        private readonly String[] phoneNumbers;
        private readonly String pronunciation;
        private readonly String title;

        private readonly String url;

        public AddressBookParsedResult(String[] names, String pronunciation, String[] phoneNumbers, String[] emails,
                                       String note, String[] addresses, String org, String birthday, String title,
                                       String url) : base(ParsedResultType.ADDRESSBOOK)
        {
            this.names = names;
            this.pronunciation = pronunciation;
            this.phoneNumbers = phoneNumbers;
            this.emails = emails;
            this.note = note;
            this.addresses = addresses;
            this.org = org;
            this.birthday = birthday;
            this.title = title;
            this.url = url;
        }

        public String[] Names
        {
            get
            {
                return names;
            }
        }

        /// <summary> In Japanese, the name is written in kanji, which can have multiple readings. Therefore a hint
        /// is often provided, called furigana, which spells the name phonetically.
        /// 
        /// </summary>
        /// <returns> The pronunciation of the getNames() field, often in hiragana or katakana.
        /// </returns>
        public String Pronunciation
        {
            get
            {
                return pronunciation;
            }
        }

        public String[] PhoneNumbers
        {
            get
            {
                return phoneNumbers;
            }
        }

        public String[] Emails
        {
            get
            {
                return emails;
            }
        }

        public String Note
        {
            get
            {
                return note;
            }
        }

        public String[] Addresses
        {
            get
            {
                return addresses;
            }
        }

        public String Title
        {
            get
            {
                return title;
            }
        }

        public String Org
        {
            get
            {
                return org;
            }
        }

        public String URL
        {
            get
            {
                return url;
            }
        }

        /// <returns> birthday formatted as yyyyMMdd (e.g. 19780917)
        /// </returns>
        public String Birthday
        {
            get
            {
                return birthday;
            }
        }

        public override String DisplayResult
        {
            get
            {
                var result = new StringBuilder(100);
                maybeAppend(names, result);
                maybeAppend(pronunciation, result);
                maybeAppend(title, result);
                maybeAppend(org, result);
                maybeAppend(addresses, result);
                maybeAppend(phoneNumbers, result);
                maybeAppend(emails, result);
                maybeAppend(url, result);
                maybeAppend(birthday, result);
                maybeAppend(note, result);
                return result.ToString();
            }
        }


    }
}