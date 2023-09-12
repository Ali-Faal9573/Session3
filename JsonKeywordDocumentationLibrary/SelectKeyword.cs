using JsonKeywordDocumentationApp;

namespace JsonKeywordDocumentationLibrary
{
    public static class SelectKeyword
    {

        public static string keywordinfo(string keyword)
        {
            string projectPath = ProjectPath.GetPath();


            switch (keyword.ToLower())
            {
                case "abstract":
                    string abstractfileToRead = projectPath + @"\KeyWords\AbstractKeywordInfo.json";
                    return abstractfileToRead;
                case "async":
                    string asyncfileToRead = projectPath + @"\KeyWords\AsyncKeywordInfo.json";
                    return asyncfileToRead;
                case "const":
                    string constfileToRead = projectPath + @"\KeyWords\ConstKeywordInfo.json";
                    return constfileToRead;
                case "event":
                    string eventfileToRead = projectPath + @"\KeyWords\EventKeywordInfo.json";
                    return eventfileToRead;
                case "extern":
                    string externfileToRead = projectPath + @"\KeyWords\ExternKeywordInfo.json";
                    return externfileToRead;
                case "new":
                    string newfileToRead = projectPath + @"\KeyWords\NewKeywordInfo.json";
                    return newfileToRead;
                case "override":
                    string overridefileToRead = projectPath + @"\KeyWords\OverrideKeuwordInfo.json";
                    return overridefileToRead;
                case "partial":
                    string partialfileToRead = projectPath + @"\KeyWords\PartialKeywordInfo.json";
                    return partialfileToRead;
                case "readonly":
                    string readonlyfileToRead = projectPath + @"\KeyWords\ReadonlyKeywordInfo.json";
                    return readonlyfileToRead;
                case "sealed":
                    string sealedfileToRead = projectPath + @"\KeyWords\SealedKeywordInfo.json";
                    return sealedfileToRead;
                case "static":
                    string staticfileToRead = projectPath + @"\KeyWords\StaticKeywordInfo.json";
                    return staticfileToRead;
                case "unsafe":
                    string unsafefileToRead = projectPath + @"\KeyWords\UnsafeKeywordInfo.json";
                    return unsafefileToRead;
                case "virtual":
                    string virtualfileToRead = projectPath + @"\KeyWords\VirtualKeywordInfo.json";
                    return virtualfileToRead;
                case "volatile":
                    string volatilefileToRead = projectPath + @"\KeyWords\VolatileKeywordInfo.json";
                    return volatilefileToRead;
                default:
                    return null;
            }
        }
    }
}
