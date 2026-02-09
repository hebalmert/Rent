using ClosedXML.Excel;

namespace Rent.AppInfra.ExcelHelper;

public interface IExcelImporter
{
    List<T> ParseFromBase64<T>(string base64, Func<IXLRow, T> map);
}
