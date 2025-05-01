using System.Data.Common;
using System.Xml.Linq;

namespace Dal;
internal static class Config
{
    private const string FILE_PATH = @"../xml/data-config.xml";
    private const string PRODUCT_CODE = "productCode";
    private const string SALE_CODE = "saleCode";

    private static XElement configXml = XElement.Load(FILE_PATH);
    public static int codeProduct
    {
        get
        {
            int currentProdCode = int.Parse(configXml.Element(PRODUCT_CODE)?.Value ?? "0");
            currentProdCode++;
            configXml.Element(PRODUCT_CODE)?.SetValue(currentProdCode);
            configXml.Save(FILE_PATH);
            return currentProdCode;
        }
    }

    public static int codeSale
    {
        get
        {
            int currentSaledCode = int.Parse(configXml.Element(SALE_CODE)?.Value ?? "0");
            currentSaledCode++;
            configXml.Element(SALE_CODE)?.SetValue(currentSaledCode);
            configXml.Save(FILE_PATH);
            return currentSaledCode;
        }
    }



}
