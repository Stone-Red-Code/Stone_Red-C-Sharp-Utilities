<a name='assembly'></a>
# Stone_Red-C-Sharp-Utilities

## Contents

- [BoolExt](#T-Stone_Red_Utilities-BoolExtentions-BoolExt 'Stone_Red_Utilities.BoolExtentions.BoolExt')
  - [FromInt(bol,input)](#M-Stone_Red_Utilities-BoolExtentions-BoolExt-FromInt-System-Boolean@,System-Int32- 'Stone_Red_Utilities.BoolExtentions.BoolExt.FromInt(System.Boolean@,System.Int32)')
  - [OneWayFalse(bol,input)](#M-Stone_Red_Utilities-BoolExtentions-BoolExt-OneWayFalse-System-Boolean@,System-Boolean- 'Stone_Red_Utilities.BoolExtentions.BoolExt.OneWayFalse(System.Boolean@,System.Boolean)')
  - [OneWayTrue(bol,input)](#M-Stone_Red_Utilities-BoolExtentions-BoolExt-OneWayTrue-System-Boolean@,System-Boolean- 'Stone_Red_Utilities.BoolExtentions.BoolExt.OneWayTrue(System.Boolean@,System.Boolean)')
  - [ToInt(input)](#M-Stone_Red_Utilities-BoolExtentions-BoolExt-ToInt-System-Boolean- 'Stone_Red_Utilities.BoolExtentions.BoolExt.ToInt(System.Boolean)')
- [CollectionExt](#T-Stone_Red_Utilities-CollectionExtentions-CollectionExt 'Stone_Red_Utilities.CollectionExtentions.CollectionExt')
  - [PrintTable\`\`1(array,tableStyle)](#M-Stone_Red_Utilities-CollectionExtentions-CollectionExt-PrintTable``1-``0[0-,0-],Stone_Red_Utilities-CollectionExtentions-TableStyle- 'Stone_Red_Utilities.CollectionExtentions.CollectionExt.PrintTable``1(``0[0:,0:],Stone_Red_Utilities.CollectionExtentions.TableStyle)')
  - [Print\`\`1(collection,delimiter,printToDebugConsole)](#M-Stone_Red_Utilities-CollectionExtentions-CollectionExt-Print``1-System-Collections-Generic-IEnumerable{``0},System-Char,System-Boolean- 'Stone_Red_Utilities.CollectionExtentions.CollectionExt.Print``1(System.Collections.Generic.IEnumerable{``0},System.Char,System.Boolean)')
- [ConsoleExt](#T-Stone_Red_Utilities-ConsoleExtentions-ConsoleExt 'Stone_Red_Utilities.ConsoleExtentions.ConsoleExt')
  - [Pause(enterKeyOnly,customMessage)](#M-Stone_Red_Utilities-ConsoleExtentions-ConsoleExt-Pause-System-Boolean,System-String- 'Stone_Red_Utilities.ConsoleExtentions.ConsoleExt.Pause(System.Boolean,System.String)')
  - [Write(value,color)](#M-Stone_Red_Utilities-ConsoleExtentions-ConsoleExt-Write-System-Object,System-ConsoleColor- 'Stone_Red_Utilities.ConsoleExtentions.ConsoleExt.Write(System.Object,System.ConsoleColor)')
  - [WriteLine(value,color)](#M-Stone_Red_Utilities-ConsoleExtentions-ConsoleExt-WriteLine-System-Object,System-ConsoleColor- 'Stone_Red_Utilities.ConsoleExtentions.ConsoleExt.WriteLine(System.Object,System.ConsoleColor)')
- [DecimalFluent](#T-Stone_Red_Utilities-FluentMath-DecimalFluent 'Stone_Red_Utilities.FluentMath.DecimalFluent')
  - [Abs()](#M-Stone_Red_Utilities-FluentMath-DecimalFluent-Abs-System-Decimal- 'Stone_Red_Utilities.FluentMath.DecimalFluent.Abs(System.Decimal)')
  - [Add(num,value)](#M-Stone_Red_Utilities-FluentMath-DecimalFluent-Add-System-Decimal,System-Decimal- 'Stone_Red_Utilities.FluentMath.DecimalFluent.Add(System.Decimal,System.Decimal)')
  - [Ceiling()](#M-Stone_Red_Utilities-FluentMath-DecimalFluent-Ceiling-System-Decimal- 'Stone_Red_Utilities.FluentMath.DecimalFluent.Ceiling(System.Decimal)')
  - [Clamp()](#M-Stone_Red_Utilities-FluentMath-DecimalFluent-Clamp-System-Decimal,System-Decimal,System-Decimal- 'Stone_Red_Utilities.FluentMath.DecimalFluent.Clamp(System.Decimal,System.Decimal,System.Decimal)')
  - [Divide(num,value)](#M-Stone_Red_Utilities-FluentMath-DecimalFluent-Divide-System-Decimal,System-Decimal- 'Stone_Red_Utilities.FluentMath.DecimalFluent.Divide(System.Decimal,System.Decimal)')
  - [Floor()](#M-Stone_Red_Utilities-FluentMath-DecimalFluent-Floor-System-Decimal- 'Stone_Red_Utilities.FluentMath.DecimalFluent.Floor(System.Decimal)')
  - [Multiply(num,value)](#M-Stone_Red_Utilities-FluentMath-DecimalFluent-Multiply-System-Decimal,System-Decimal- 'Stone_Red_Utilities.FluentMath.DecimalFluent.Multiply(System.Decimal,System.Decimal)')
  - [Round()](#M-Stone_Red_Utilities-FluentMath-DecimalFluent-Round-System-Decimal- 'Stone_Red_Utilities.FluentMath.DecimalFluent.Round(System.Decimal)')
  - [Round()](#M-Stone_Red_Utilities-FluentMath-DecimalFluent-Round-System-Decimal,System-MidpointRounding- 'Stone_Red_Utilities.FluentMath.DecimalFluent.Round(System.Decimal,System.MidpointRounding)')
  - [Round()](#M-Stone_Red_Utilities-FluentMath-DecimalFluent-Round-System-Decimal,System-Int32- 'Stone_Red_Utilities.FluentMath.DecimalFluent.Round(System.Decimal,System.Int32)')
  - [Round()](#M-Stone_Red_Utilities-FluentMath-DecimalFluent-Round-System-Decimal,System-Int32,System-MidpointRounding- 'Stone_Red_Utilities.FluentMath.DecimalFluent.Round(System.Decimal,System.Int32,System.MidpointRounding)')
  - [Sign()](#M-Stone_Red_Utilities-FluentMath-DecimalFluent-Sign-System-Decimal- 'Stone_Red_Utilities.FluentMath.DecimalFluent.Sign(System.Decimal)')
  - [Subtract(num,value)](#M-Stone_Red_Utilities-FluentMath-DecimalFluent-Subtract-System-Decimal,System-Decimal- 'Stone_Red_Utilities.FluentMath.DecimalFluent.Subtract(System.Decimal,System.Decimal)')
  - [ToDouble(num)](#M-Stone_Red_Utilities-FluentMath-DecimalFluent-ToDouble-System-Decimal- 'Stone_Red_Utilities.FluentMath.DecimalFluent.ToDouble(System.Decimal)')
  - [ToInt16(num)](#M-Stone_Red_Utilities-FluentMath-DecimalFluent-ToInt16-System-Decimal- 'Stone_Red_Utilities.FluentMath.DecimalFluent.ToInt16(System.Decimal)')
  - [ToInt32(num)](#M-Stone_Red_Utilities-FluentMath-DecimalFluent-ToInt32-System-Decimal- 'Stone_Red_Utilities.FluentMath.DecimalFluent.ToInt32(System.Decimal)')
  - [ToInt64(num)](#M-Stone_Red_Utilities-FluentMath-DecimalFluent-ToInt64-System-Decimal- 'Stone_Red_Utilities.FluentMath.DecimalFluent.ToInt64(System.Decimal)')
  - [ToSingle(num)](#M-Stone_Red_Utilities-FluentMath-DecimalFluent-ToSingle-System-Decimal- 'Stone_Red_Utilities.FluentMath.DecimalFluent.ToSingle(System.Decimal)')
  - [Truncate()](#M-Stone_Red_Utilities-FluentMath-DecimalFluent-Truncate-System-Decimal- 'Stone_Red_Utilities.FluentMath.DecimalFluent.Truncate(System.Decimal)')
- [DoubleFluent](#T-Stone_Red_Utilities-FluentMath-DoubleFluent 'Stone_Red_Utilities.FluentMath.DoubleFluent')
  - [Abs()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Abs-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Abs(System.Double)')
  - [Acos()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Acos-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Acos(System.Double)')
  - [Acosh()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Acosh-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Acosh(System.Double)')
  - [Add(num,value)](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Add-System-Double,System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Add(System.Double,System.Double)')
  - [Asin()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Asin-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Asin(System.Double)')
  - [Asinh()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Asinh-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Asinh(System.Double)')
  - [Atan()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Atan-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Atan(System.Double)')
  - [Atan2()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Atan2-System-Double,System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Atan2(System.Double,System.Double)')
  - [Atanh()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Atanh-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Atanh(System.Double)')
  - [Cbrt()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Cbrt-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Cbrt(System.Double)')
  - [Ceiling()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Ceiling-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Ceiling(System.Double)')
  - [Clamp()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Clamp-System-Double,System-Double,System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Clamp(System.Double,System.Double,System.Double)')
  - [Cos()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Cos-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Cos(System.Double)')
  - [Cosh()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Cosh-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Cosh(System.Double)')
  - [Divide(num,value)](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Divide-System-Double,System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Divide(System.Double,System.Double)')
  - [Exp()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Exp-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Exp(System.Double)')
  - [Floor()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Floor-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Floor(System.Double)')
  - [IEEERemainder()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-IEEERemainder-System-Double,System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.IEEERemainder(System.Double,System.Double)')
  - [Log()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Log-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Log(System.Double)')
  - [Log()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Log-System-Double,System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Log(System.Double,System.Double)')
  - [Log10()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Log10-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Log10(System.Double)')
  - [Multiply(num,value)](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Multiply-System-Double,System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Multiply(System.Double,System.Double)')
  - [Pow()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Pow-System-Double,System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Pow(System.Double,System.Double)')
  - [Round()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Round-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Round(System.Double)')
  - [Round()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Round-System-Double,System-MidpointRounding- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Round(System.Double,System.MidpointRounding)')
  - [Round()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Round-System-Double,System-Int32- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Round(System.Double,System.Int32)')
  - [Round()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Round-System-Double,System-Int32,System-MidpointRounding- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Round(System.Double,System.Int32,System.MidpointRounding)')
  - [Sign()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Sign-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Sign(System.Double)')
  - [Sin()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Sin-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Sin(System.Double)')
  - [Sinh()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Sinh-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Sinh(System.Double)')
  - [Sqrt()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Sqrt-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Sqrt(System.Double)')
  - [Subtract(num,value)](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Subtract-System-Double,System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Subtract(System.Double,System.Double)')
  - [Tan()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Tan-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Tan(System.Double)')
  - [Tanh()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Tanh-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Tanh(System.Double)')
  - [ToDecimal(num)](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-ToDecimal-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.ToDecimal(System.Double)')
  - [ToInt16(num)](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-ToInt16-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.ToInt16(System.Double)')
  - [ToInt32(num)](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-ToInt32-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.ToInt32(System.Double)')
  - [ToInt64(num)](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-ToInt64-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.ToInt64(System.Double)')
  - [ToSingle(num)](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-ToSingle-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.ToSingle(System.Double)')
  - [Truncate()](#M-Stone_Red_Utilities-FluentMath-DoubleFluent-Truncate-System-Double- 'Stone_Red_Utilities.FluentMath.DoubleFluent.Truncate(System.Double)')
- [FormatConfig](#T-Stone_Red_Utilities-Logging-FormatConfig 'Stone_Red_Utilities.Logging.FormatConfig')
  - [ConsoleFormat](#P-Stone_Red_Utilities-Logging-FormatConfig-ConsoleFormat 'Stone_Red_Utilities.Logging.FormatConfig.ConsoleFormat')
  - [DebugConsoleFormat](#P-Stone_Red_Utilities-Logging-FormatConfig-DebugConsoleFormat 'Stone_Red_Utilities.Logging.FormatConfig.DebugConsoleFormat')
  - [FileFormat](#P-Stone_Red_Utilities-Logging-FormatConfig-FileFormat 'Stone_Red_Utilities.Logging.FormatConfig.FileFormat')
- [Int16Fluent](#T-Stone_Red_Utilities-FluentMath-Int16Fluent 'Stone_Red_Utilities.FluentMath.Int16Fluent')
  - [Abs()](#M-Stone_Red_Utilities-FluentMath-Int16Fluent-Abs-System-Int16- 'Stone_Red_Utilities.FluentMath.Int16Fluent.Abs(System.Int16)')
  - [Add(num,value)](#M-Stone_Red_Utilities-FluentMath-Int16Fluent-Add-System-Int16,System-Int16- 'Stone_Red_Utilities.FluentMath.Int16Fluent.Add(System.Int16,System.Int16)')
  - [Clamp()](#M-Stone_Red_Utilities-FluentMath-Int16Fluent-Clamp-System-Int16,System-Int16,System-Int16- 'Stone_Red_Utilities.FluentMath.Int16Fluent.Clamp(System.Int16,System.Int16,System.Int16)')
  - [Divide(num,value)](#M-Stone_Red_Utilities-FluentMath-Int16Fluent-Divide-System-Int16,System-Int16- 'Stone_Red_Utilities.FluentMath.Int16Fluent.Divide(System.Int16,System.Int16)')
  - [Multiply(num,value)](#M-Stone_Red_Utilities-FluentMath-Int16Fluent-Multiply-System-Int16,System-Int16- 'Stone_Red_Utilities.FluentMath.Int16Fluent.Multiply(System.Int16,System.Int16)')
  - [Sign()](#M-Stone_Red_Utilities-FluentMath-Int16Fluent-Sign-System-Int16- 'Stone_Red_Utilities.FluentMath.Int16Fluent.Sign(System.Int16)')
  - [Subtract(num,value)](#M-Stone_Red_Utilities-FluentMath-Int16Fluent-Subtract-System-Int16,System-Int16- 'Stone_Red_Utilities.FluentMath.Int16Fluent.Subtract(System.Int16,System.Int16)')
  - [ToDecimal(num)](#M-Stone_Red_Utilities-FluentMath-Int16Fluent-ToDecimal-System-Int16- 'Stone_Red_Utilities.FluentMath.Int16Fluent.ToDecimal(System.Int16)')
  - [ToDouble(num)](#M-Stone_Red_Utilities-FluentMath-Int16Fluent-ToDouble-System-Int16- 'Stone_Red_Utilities.FluentMath.Int16Fluent.ToDouble(System.Int16)')
  - [ToInt32(num)](#M-Stone_Red_Utilities-FluentMath-Int16Fluent-ToInt32-System-Int16- 'Stone_Red_Utilities.FluentMath.Int16Fluent.ToInt32(System.Int16)')
  - [ToInt64(num)](#M-Stone_Red_Utilities-FluentMath-Int16Fluent-ToInt64-System-Int16- 'Stone_Red_Utilities.FluentMath.Int16Fluent.ToInt64(System.Int16)')
  - [ToSingle(num)](#M-Stone_Red_Utilities-FluentMath-Int16Fluent-ToSingle-System-Int16- 'Stone_Red_Utilities.FluentMath.Int16Fluent.ToSingle(System.Int16)')
- [Int32Fluent](#T-Stone_Red_Utilities-FluentMath-Int32Fluent 'Stone_Red_Utilities.FluentMath.Int32Fluent')
  - [Abs()](#M-Stone_Red_Utilities-FluentMath-Int32Fluent-Abs-System-Int32- 'Stone_Red_Utilities.FluentMath.Int32Fluent.Abs(System.Int32)')
  - [Add(num,value)](#M-Stone_Red_Utilities-FluentMath-Int32Fluent-Add-System-Int32,System-Int32- 'Stone_Red_Utilities.FluentMath.Int32Fluent.Add(System.Int32,System.Int32)')
  - [Clamp()](#M-Stone_Red_Utilities-FluentMath-Int32Fluent-Clamp-System-Int32,System-Int32,System-Int32- 'Stone_Red_Utilities.FluentMath.Int32Fluent.Clamp(System.Int32,System.Int32,System.Int32)')
  - [Divide(num,value)](#M-Stone_Red_Utilities-FluentMath-Int32Fluent-Divide-System-Int32,System-Int32- 'Stone_Red_Utilities.FluentMath.Int32Fluent.Divide(System.Int32,System.Int32)')
  - [Multiply(num,value)](#M-Stone_Red_Utilities-FluentMath-Int32Fluent-Multiply-System-Int32,System-Int32- 'Stone_Red_Utilities.FluentMath.Int32Fluent.Multiply(System.Int32,System.Int32)')
  - [Sign()](#M-Stone_Red_Utilities-FluentMath-Int32Fluent-Sign-System-Int32- 'Stone_Red_Utilities.FluentMath.Int32Fluent.Sign(System.Int32)')
  - [Subtract(num,value)](#M-Stone_Red_Utilities-FluentMath-Int32Fluent-Subtract-System-Int32,System-Int32- 'Stone_Red_Utilities.FluentMath.Int32Fluent.Subtract(System.Int32,System.Int32)')
  - [ToDecimal(num)](#M-Stone_Red_Utilities-FluentMath-Int32Fluent-ToDecimal-System-Int32- 'Stone_Red_Utilities.FluentMath.Int32Fluent.ToDecimal(System.Int32)')
  - [ToDouble(num)](#M-Stone_Red_Utilities-FluentMath-Int32Fluent-ToDouble-System-Int32- 'Stone_Red_Utilities.FluentMath.Int32Fluent.ToDouble(System.Int32)')
  - [ToInt16(num)](#M-Stone_Red_Utilities-FluentMath-Int32Fluent-ToInt16-System-Int32- 'Stone_Red_Utilities.FluentMath.Int32Fluent.ToInt16(System.Int32)')
  - [ToInt64(num)](#M-Stone_Red_Utilities-FluentMath-Int32Fluent-ToInt64-System-Int32- 'Stone_Red_Utilities.FluentMath.Int32Fluent.ToInt64(System.Int32)')
  - [ToSingle(num)](#M-Stone_Red_Utilities-FluentMath-Int32Fluent-ToSingle-System-Int32- 'Stone_Red_Utilities.FluentMath.Int32Fluent.ToSingle(System.Int32)')
- [Int64Fluent](#T-Stone_Red_Utilities-FluentMath-Int64Fluent 'Stone_Red_Utilities.FluentMath.Int64Fluent')
  - [Abs()](#M-Stone_Red_Utilities-FluentMath-Int64Fluent-Abs-System-Int64- 'Stone_Red_Utilities.FluentMath.Int64Fluent.Abs(System.Int64)')
  - [Add(num,value)](#M-Stone_Red_Utilities-FluentMath-Int64Fluent-Add-System-Int64,System-Int64- 'Stone_Red_Utilities.FluentMath.Int64Fluent.Add(System.Int64,System.Int64)')
  - [Clamp()](#M-Stone_Red_Utilities-FluentMath-Int64Fluent-Clamp-System-Int64,System-Int64,System-Int64- 'Stone_Red_Utilities.FluentMath.Int64Fluent.Clamp(System.Int64,System.Int64,System.Int64)')
  - [Divide(num,value)](#M-Stone_Red_Utilities-FluentMath-Int64Fluent-Divide-System-Int64,System-Int64- 'Stone_Red_Utilities.FluentMath.Int64Fluent.Divide(System.Int64,System.Int64)')
  - [Multiply(num,value)](#M-Stone_Red_Utilities-FluentMath-Int64Fluent-Multiply-System-Int64,System-Int64- 'Stone_Red_Utilities.FluentMath.Int64Fluent.Multiply(System.Int64,System.Int64)')
  - [Sign()](#M-Stone_Red_Utilities-FluentMath-Int64Fluent-Sign-System-Int64- 'Stone_Red_Utilities.FluentMath.Int64Fluent.Sign(System.Int64)')
  - [Subtract(num,value)](#M-Stone_Red_Utilities-FluentMath-Int64Fluent-Subtract-System-Int64,System-Int64- 'Stone_Red_Utilities.FluentMath.Int64Fluent.Subtract(System.Int64,System.Int64)')
  - [ToDecimal(num)](#M-Stone_Red_Utilities-FluentMath-Int64Fluent-ToDecimal-System-Int64- 'Stone_Red_Utilities.FluentMath.Int64Fluent.ToDecimal(System.Int64)')
  - [ToDouble(num)](#M-Stone_Red_Utilities-FluentMath-Int64Fluent-ToDouble-System-Int64- 'Stone_Red_Utilities.FluentMath.Int64Fluent.ToDouble(System.Int64)')
  - [ToInt16(num)](#M-Stone_Red_Utilities-FluentMath-Int64Fluent-ToInt16-System-Int64- 'Stone_Red_Utilities.FluentMath.Int64Fluent.ToInt16(System.Int64)')
  - [ToInt32(num)](#M-Stone_Red_Utilities-FluentMath-Int64Fluent-ToInt32-System-Int64- 'Stone_Red_Utilities.FluentMath.Int64Fluent.ToInt32(System.Int64)')
  - [ToSingle(num)](#M-Stone_Red_Utilities-FluentMath-Int64Fluent-ToSingle-System-Int64- 'Stone_Red_Utilities.FluentMath.Int64Fluent.ToSingle(System.Int64)')
- [LogConfig](#T-Stone_Red_Utilities-Logging-LogConfig 'Stone_Red_Utilities.Logging.LogConfig')
  - [DebugConfig](#P-Stone_Red_Utilities-Logging-LogConfig-DebugConfig 'Stone_Red_Utilities.Logging.LogConfig.DebugConfig')
  - [ErrorConfig](#P-Stone_Red_Utilities-Logging-LogConfig-ErrorConfig 'Stone_Red_Utilities.Logging.LogConfig.ErrorConfig')
  - [FatalConfig](#P-Stone_Red_Utilities-Logging-LogConfig-FatalConfig 'Stone_Red_Utilities.Logging.LogConfig.FatalConfig')
  - [FormatConfig](#P-Stone_Red_Utilities-Logging-LogConfig-FormatConfig 'Stone_Red_Utilities.Logging.LogConfig.FormatConfig')
  - [InfoConfig](#P-Stone_Red_Utilities-Logging-LogConfig-InfoConfig 'Stone_Red_Utilities.Logging.LogConfig.InfoConfig')
  - [WarnConfig](#P-Stone_Red_Utilities-Logging-LogConfig-WarnConfig 'Stone_Red_Utilities.Logging.LogConfig.WarnConfig')
- [LogFormatType](#T-Stone_Red_Utilities-Logging-LogFormatType 'Stone_Red_Utilities.Logging.LogFormatType')
  - [DateTime](#F-Stone_Red_Utilities-Logging-LogFormatType-DateTime 'Stone_Red_Utilities.Logging.LogFormatType.DateTime')
  - [FilePath](#F-Stone_Red_Utilities-Logging-LogFormatType-FilePath 'Stone_Red_Utilities.Logging.LogFormatType.FilePath')
  - [LineNumber](#F-Stone_Red_Utilities-Logging-LogFormatType-LineNumber 'Stone_Red_Utilities.Logging.LogFormatType.LineNumber')
  - [LogSeverity](#F-Stone_Red_Utilities-Logging-LogFormatType-LogSeverity 'Stone_Red_Utilities.Logging.LogFormatType.LogSeverity')
  - [MemberName](#F-Stone_Red_Utilities-Logging-LogFormatType-MemberName 'Stone_Red_Utilities.Logging.LogFormatType.MemberName')
  - [Message](#F-Stone_Red_Utilities-Logging-LogFormatType-Message 'Stone_Red_Utilities.Logging.LogFormatType.Message')
  - [Source](#F-Stone_Red_Utilities-Logging-LogFormatType-Source 'Stone_Red_Utilities.Logging.LogFormatType.Source')
- [LogSeverity](#T-Stone_Red_Utilities-Logging-LogSeverity 'Stone_Red_Utilities.Logging.LogSeverity')
  - [Debug](#F-Stone_Red_Utilities-Logging-LogSeverity-Debug 'Stone_Red_Utilities.Logging.LogSeverity.Debug')
  - [Error](#F-Stone_Red_Utilities-Logging-LogSeverity-Error 'Stone_Red_Utilities.Logging.LogSeverity.Error')
  - [Fatal](#F-Stone_Red_Utilities-Logging-LogSeverity-Fatal 'Stone_Red_Utilities.Logging.LogSeverity.Fatal')
  - [Info](#F-Stone_Red_Utilities-Logging-LogSeverity-Info 'Stone_Red_Utilities.Logging.LogSeverity.Info')
  - [Warn](#F-Stone_Red_Utilities-Logging-LogSeverity-Warn 'Stone_Red_Utilities.Logging.LogSeverity.Warn')
- [LogTarget](#T-Stone_Red_Utilities-Logging-LogTarget 'Stone_Red_Utilities.Logging.LogTarget')
  - [Console](#F-Stone_Red_Utilities-Logging-LogTarget-Console 'Stone_Red_Utilities.Logging.LogTarget.Console')
  - [DebugConsole](#F-Stone_Red_Utilities-Logging-LogTarget-DebugConsole 'Stone_Red_Utilities.Logging.LogTarget.DebugConsole')
  - [File](#F-Stone_Red_Utilities-Logging-LogTarget-File 'Stone_Red_Utilities.Logging.LogTarget.File')
- [Logger](#T-Stone_Red_Utilities-Logging-Logger 'Stone_Red_Utilities.Logging.Logger')
  - [Config](#P-Stone_Red_Utilities-Logging-Logger-Config 'Stone_Red_Utilities.Logging.Logger.Config')
  - [ClearLogFile()](#M-Stone_Red_Utilities-Logging-Logger-ClearLogFile-Stone_Red_Utilities-Logging-LogSeverity- 'Stone_Red_Utilities.Logging.Logger.ClearLogFile(Stone_Red_Utilities.Logging.LogSeverity)')
  - [Log(message,source,logSeverity,memberName,sourceFilePath,sourceLineNumber)](#M-Stone_Red_Utilities-Logging-Logger-Log-System-String,System-String,Stone_Red_Utilities-Logging-LogSeverity,System-String,System-String,System-Int32- 'Stone_Red_Utilities.Logging.Logger.Log(System.String,System.String,Stone_Red_Utilities.Logging.LogSeverity,System.String,System.String,System.Int32)')
  - [Log(message,logSeverity,memberName,sourceFilePath,sourceLineNumber)](#M-Stone_Red_Utilities-Logging-Logger-Log-System-String,Stone_Red_Utilities-Logging-LogSeverity,System-String,System-String,System-Int32- 'Stone_Red_Utilities.Logging.Logger.Log(System.String,Stone_Red_Utilities.Logging.LogSeverity,System.String,System.String,System.Int32)')
  - [LogIf(condition,message,source,logSeverity,memberName,sourceFilePath,sourceLineNumber)](#M-Stone_Red_Utilities-Logging-Logger-LogIf-System-Boolean,System-String,System-String,Stone_Red_Utilities-Logging-LogSeverity,System-String,System-String,System-Int32- 'Stone_Red_Utilities.Logging.Logger.LogIf(System.Boolean,System.String,System.String,Stone_Red_Utilities.Logging.LogSeverity,System.String,System.String,System.Int32)')
  - [LogIf(condition,message,logSeverity,memberName,sourceFilePath,sourceLineNumber)](#M-Stone_Red_Utilities-Logging-Logger-LogIf-System-Boolean,System-String,Stone_Red_Utilities-Logging-LogSeverity,System-String,System-String,System-Int32- 'Stone_Red_Utilities.Logging.Logger.LogIf(System.Boolean,System.String,Stone_Red_Utilities.Logging.LogSeverity,System.String,System.String,System.Int32)')
- [OutputConfig](#T-Stone_Red_Utilities-Logging-OutputConfig 'Stone_Red_Utilities.Logging.OutputConfig')
  - [Color](#P-Stone_Red_Utilities-Logging-OutputConfig-Color 'Stone_Red_Utilities.Logging.OutputConfig.Color')
  - [FilePath](#P-Stone_Red_Utilities-Logging-OutputConfig-FilePath 'Stone_Red_Utilities.Logging.OutputConfig.FilePath')
  - [LogTarget](#P-Stone_Red_Utilities-Logging-OutputConfig-LogTarget 'Stone_Red_Utilities.Logging.OutputConfig.LogTarget')
- [RandomExt](#T-Stone_Red_Utilities-RandomExtentions-RandomExt 'Stone_Red_Utilities.RandomExtentions.RandomExt')
  - [NextBool(random)](#M-Stone_Red_Utilities-RandomExtentions-RandomExt-NextBool-System-Random- 'Stone_Red_Utilities.RandomExtentions.RandomExt.NextBool(System.Random)')
  - [NextEnum\`\`1(random)](#M-Stone_Red_Utilities-RandomExtentions-RandomExt-NextEnum``1-System-Random- 'Stone_Red_Utilities.RandomExtentions.RandomExt.NextEnum``1(System.Random)')
  - [NextItem\`\`1(random,collection)](#M-Stone_Red_Utilities-RandomExtentions-RandomExt-NextItem``1-System-Random,System-Collections-Generic-IEnumerable{``0}- 'Stone_Red_Utilities.RandomExtentions.RandomExt.NextItem``1(System.Random,System.Collections.Generic.IEnumerable{``0})')
- [Rectangle](#T-Stone_Red_Utilities-FluentMath-Shapes-Rectangle 'Stone_Red_Utilities.FluentMath.Shapes.Rectangle')
  - [#ctor(length,width)](#M-Stone_Red_Utilities-FluentMath-Shapes-Rectangle-#ctor-System-Double,System-Double- 'Stone_Red_Utilities.FluentMath.Shapes.Rectangle.#ctor(System.Double,System.Double)')
  - [Area](#P-Stone_Red_Utilities-FluentMath-Shapes-Rectangle-Area 'Stone_Red_Utilities.FluentMath.Shapes.Rectangle.Area')
  - [Diagonal](#P-Stone_Red_Utilities-FluentMath-Shapes-Rectangle-Diagonal 'Stone_Red_Utilities.FluentMath.Shapes.Rectangle.Diagonal')
  - [Length](#P-Stone_Red_Utilities-FluentMath-Shapes-Rectangle-Length 'Stone_Red_Utilities.FluentMath.Shapes.Rectangle.Length')
  - [Perimeter](#P-Stone_Red_Utilities-FluentMath-Shapes-Rectangle-Perimeter 'Stone_Red_Utilities.FluentMath.Shapes.Rectangle.Perimeter')
  - [Width](#P-Stone_Red_Utilities-FluentMath-Shapes-Rectangle-Width 'Stone_Red_Utilities.FluentMath.Shapes.Rectangle.Width')
- [Reflection](#T-Stone_Red_Utilities-Reflection-Reflection 'Stone_Red_Utilities.Reflection.Reflection')
  - [CopyProperties\`\`1(obj)](#M-Stone_Red_Utilities-Reflection-Reflection-CopyProperties``1-System-Object- 'Stone_Red_Utilities.Reflection.Reflection.CopyProperties``1(System.Object)')
  - [CopyProperties\`\`1(obj,newObj)](#M-Stone_Red_Utilities-Reflection-Reflection-CopyProperties``1-System-Object,``0- 'Stone_Red_Utilities.Reflection.Reflection.CopyProperties``1(System.Object,``0)')
- [SingleFluent](#T-Stone_Red_Utilities-FluentMath-SingleFluent 'Stone_Red_Utilities.FluentMath.SingleFluent')
  - [Abs()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Abs-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Abs(System.Single)')
  - [Acos()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Acos-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Acos(System.Single)')
  - [Acosh()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Acosh-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Acosh(System.Single)')
  - [Add(num,value)](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Add-System-Single,System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Add(System.Single,System.Single)')
  - [Asin()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Asin-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Asin(System.Single)')
  - [Asinh()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Asinh-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Asinh(System.Single)')
  - [Atan()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Atan-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Atan(System.Single)')
  - [Atan2()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Atan2-System-Single,System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Atan2(System.Single,System.Single)')
  - [Atanh()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Atanh-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Atanh(System.Single)')
  - [Cbrt()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Cbrt-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Cbrt(System.Single)')
  - [Ceiling()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Ceiling-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Ceiling(System.Single)')
  - [Clamp()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Clamp-System-Single,System-Single,System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Clamp(System.Single,System.Single,System.Single)')
  - [Cos()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Cos-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Cos(System.Single)')
  - [Cosh()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Cosh-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Cosh(System.Single)')
  - [Divide(num,value)](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Divide-System-Single,System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Divide(System.Single,System.Single)')
  - [Exp()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Exp-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Exp(System.Single)')
  - [Floor()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Floor-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Floor(System.Single)')
  - [IEEERemainder()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-IEEERemainder-System-Single,System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.IEEERemainder(System.Single,System.Single)')
  - [Log()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Log-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Log(System.Single)')
  - [Log()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Log-System-Single,System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Log(System.Single,System.Single)')
  - [Log10()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Log10-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Log10(System.Single)')
  - [Multiply(num,value)](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Multiply-System-Single,System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Multiply(System.Single,System.Single)')
  - [Pow()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Pow-System-Single,System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Pow(System.Single,System.Single)')
  - [Round()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Round-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Round(System.Single)')
  - [Round()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Round-System-Single,System-MidpointRounding- 'Stone_Red_Utilities.FluentMath.SingleFluent.Round(System.Single,System.MidpointRounding)')
  - [Round()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Round-System-Single,System-Int32- 'Stone_Red_Utilities.FluentMath.SingleFluent.Round(System.Single,System.Int32)')
  - [Round()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Round-System-Single,System-Int32,System-MidpointRounding- 'Stone_Red_Utilities.FluentMath.SingleFluent.Round(System.Single,System.Int32,System.MidpointRounding)')
  - [Sign()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Sign-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Sign(System.Single)')
  - [Sin()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Sin-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Sin(System.Single)')
  - [Sinh()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Sinh-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Sinh(System.Single)')
  - [Sqrt()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Sqrt-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Sqrt(System.Single)')
  - [Subtract(num,value)](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Subtract-System-Single,System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Subtract(System.Single,System.Single)')
  - [Tan()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Tan-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Tan(System.Single)')
  - [Tanh()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Tanh-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Tanh(System.Single)')
  - [ToDecimal(num)](#M-Stone_Red_Utilities-FluentMath-SingleFluent-ToDecimal-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.ToDecimal(System.Single)')
  - [ToDouble(num)](#M-Stone_Red_Utilities-FluentMath-SingleFluent-ToDouble-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.ToDouble(System.Single)')
  - [ToInt16(num)](#M-Stone_Red_Utilities-FluentMath-SingleFluent-ToInt16-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.ToInt16(System.Single)')
  - [ToInt32(num)](#M-Stone_Red_Utilities-FluentMath-SingleFluent-ToInt32-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.ToInt32(System.Single)')
  - [ToInt64(num)](#M-Stone_Red_Utilities-FluentMath-SingleFluent-ToInt64-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.ToInt64(System.Single)')
  - [Truncate()](#M-Stone_Red_Utilities-FluentMath-SingleFluent-Truncate-System-Single- 'Stone_Red_Utilities.FluentMath.SingleFluent.Truncate(System.Single)')
- [StringExt](#T-Stone_Red_Utilities-StringExtentions-StringExt 'Stone_Red_Utilities.StringExtentions.StringExt')
  - [CorrectNewLine(str)](#M-Stone_Red_Utilities-StringExtentions-StringExt-CorrectNewLine-System-String- 'Stone_Red_Utilities.StringExtentions.StringExt.CorrectNewLine(System.String)')
  - [EqualsIgnoreCase(value,str)](#M-Stone_Red_Utilities-StringExtentions-StringExt-EqualsIgnoreCase-System-String,System-String- 'Stone_Red_Utilities.StringExtentions.StringExt.EqualsIgnoreCase(System.String,System.String)')
  - [EqualsIgnoreSpaces(value,str)](#M-Stone_Red_Utilities-StringExtentions-StringExt-EqualsIgnoreSpaces-System-String,System-String- 'Stone_Red_Utilities.StringExtentions.StringExt.EqualsIgnoreSpaces(System.String,System.String)')
  - [EqualsIgnoreSpacesAndCase(value,str)](#M-Stone_Red_Utilities-StringExtentions-StringExt-EqualsIgnoreSpacesAndCase-System-String,System-String- 'Stone_Red_Utilities.StringExtentions.StringExt.EqualsIgnoreSpacesAndCase(System.String,System.String)')
  - [RemoveWhitespaces(str)](#M-Stone_Red_Utilities-StringExtentions-StringExt-RemoveWhitespaces-System-String- 'Stone_Red_Utilities.StringExtentions.StringExt.RemoveWhitespaces(System.String)')
  - [Reverse(str)](#M-Stone_Red_Utilities-StringExtentions-StringExt-Reverse-System-String- 'Stone_Red_Utilities.StringExtentions.StringExt.Reverse(System.String)')
  - [ToFileName(str,allowSpaces)](#M-Stone_Red_Utilities-StringExtentions-StringExt-ToFileName-System-String,System-Boolean- 'Stone_Red_Utilities.StringExtentions.StringExt.ToFileName(System.String,System.Boolean)')
  - [ToPath(str,allowSpaces)](#M-Stone_Red_Utilities-StringExtentions-StringExt-ToPath-System-String,System-Boolean- 'Stone_Red_Utilities.StringExtentions.StringExt.ToPath(System.String,System.Boolean)')
  - [Truncate(str,length)](#M-Stone_Red_Utilities-StringExtentions-StringExt-Truncate-System-String,System-Int32- 'Stone_Red_Utilities.StringExtentions.StringExt.Truncate(System.String,System.Int32)')
  - [Truncate(str,length,ellipsis)](#M-Stone_Red_Utilities-StringExtentions-StringExt-Truncate-System-String,System-Int32,System-Boolean- 'Stone_Red_Utilities.StringExtentions.StringExt.Truncate(System.String,System.Int32,System.Boolean)')
- [TableStyle](#T-Stone_Red_Utilities-CollectionExtentions-TableStyle 'Stone_Red_Utilities.CollectionExtentions.TableStyle')
  - [Alternative](#F-Stone_Red_Utilities-CollectionExtentions-TableStyle-Alternative 'Stone_Red_Utilities.CollectionExtentions.TableStyle.Alternative')
  - [Default](#F-Stone_Red_Utilities-CollectionExtentions-TableStyle-Default 'Stone_Red_Utilities.CollectionExtentions.TableStyle.Default')
  - [List](#F-Stone_Red_Utilities-CollectionExtentions-TableStyle-List 'Stone_Red_Utilities.CollectionExtentions.TableStyle.List')
  - [Minimum](#F-Stone_Red_Utilities-CollectionExtentions-TableStyle-Minimum 'Stone_Red_Utilities.CollectionExtentions.TableStyle.Minimum')

<a name='T-Stone_Red_Utilities-BoolExtentions-BoolExt'></a>
## BoolExt `type`

##### Namespace

Stone_Red_Utilities.BoolExtentions

##### Summary

[Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') Extentions

<a name='M-Stone_Red_Utilities-BoolExtentions-BoolExt-FromInt-System-Boolean@,System-Int32-'></a>
### FromInt(bol,input) `method`

##### Summary

Converts int to bool.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bol | [System.Boolean@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean@ 'System.Boolean@') |  |
| input | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Stone_Red_Utilities-BoolExtentions-BoolExt-OneWayFalse-System-Boolean@,System-Boolean-'></a>
### OneWayFalse(bol,input) `method`

##### Summary

Sets value to false if input is false. If input is true the value will not change.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bol | [System.Boolean@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean@ 'System.Boolean@') |  |
| input | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-Stone_Red_Utilities-BoolExtentions-BoolExt-OneWayTrue-System-Boolean@,System-Boolean-'></a>
### OneWayTrue(bol,input) `method`

##### Summary

Sets value to true if input is true. If input is false the value will not change.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bol | [System.Boolean@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean@ 'System.Boolean@') |  |
| input | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-Stone_Red_Utilities-BoolExtentions-BoolExt-ToInt-System-Boolean-'></a>
### ToInt(input) `method`

##### Summary

Converts bool to int.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-Stone_Red_Utilities-CollectionExtentions-CollectionExt'></a>
## CollectionExt `type`

##### Namespace

Stone_Red_Utilities.CollectionExtentions

##### Summary

[IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') and [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') Extentions

<a name='M-Stone_Red_Utilities-CollectionExtentions-CollectionExt-PrintTable``1-``0[0-,0-],Stone_Red_Utilities-CollectionExtentions-TableStyle-'></a>
### PrintTable\`\`1(array,tableStyle) `method`

##### Summary

Creates and prints table from 2D array

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[0:](#T-``0[0- '``0[0:') |  |
| tableStyle | [0:]](#T-0-] '0:]') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-Stone_Red_Utilities-CollectionExtentions-CollectionExt-Print``1-System-Collections-Generic-IEnumerable{``0},System-Char,System-Boolean-'></a>
### Print\`\`1(collection,delimiter,printToDebugConsole) `method`

##### Summary

Prints all items of an [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| collection | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') |  |
| delimiter | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') |  |
| printToDebugConsole | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-Stone_Red_Utilities-ConsoleExtentions-ConsoleExt'></a>
## ConsoleExt `type`

##### Namespace

Stone_Red_Utilities.ConsoleExtentions

##### Summary

[Console](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Console 'System.Console') Extentions

<a name='M-Stone_Red_Utilities-ConsoleExtentions-ConsoleExt-Pause-System-Boolean,System-String-'></a>
### Pause(enterKeyOnly,customMessage) `method`

##### Summary

Suspends execution of the current method until the user presses a key

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enterKeyOnly | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| customMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Stone_Red_Utilities-ConsoleExtentions-ConsoleExt-Write-System-Object,System-ConsoleColor-'></a>
### Write(value,color) `method`

##### Summary

Writes the text representation of the specified object to the standard output stream.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| color | [System.ConsoleColor](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ConsoleColor 'System.ConsoleColor') |  |

<a name='M-Stone_Red_Utilities-ConsoleExtentions-ConsoleExt-WriteLine-System-Object,System-ConsoleColor-'></a>
### WriteLine(value,color) `method`

##### Summary

Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| color | [System.ConsoleColor](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ConsoleColor 'System.ConsoleColor') |  |

<a name='T-Stone_Red_Utilities-FluentMath-DecimalFluent'></a>
## DecimalFluent `type`

##### Namespace

Stone_Red_Utilities.FluentMath

##### Summary

DecimalFluent class

<a name='M-Stone_Red_Utilities-FluentMath-DecimalFluent-Abs-System-Decimal-'></a>
### Abs() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DecimalFluent-Add-System-Decimal,System-Decimal-'></a>
### Add(num,value) `method`

##### Summary

Adds the two nums

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') |  |
| value | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') |  |

<a name='M-Stone_Red_Utilities-FluentMath-DecimalFluent-Ceiling-System-Decimal-'></a>
### Ceiling() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DecimalFluent-Clamp-System-Decimal,System-Decimal,System-Decimal-'></a>
### Clamp() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DecimalFluent-Divide-System-Decimal,System-Decimal-'></a>
### Divide(num,value) `method`

##### Summary

Divides the two nums

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') |  |
| value | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') |  |

<a name='M-Stone_Red_Utilities-FluentMath-DecimalFluent-Floor-System-Decimal-'></a>
### Floor() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DecimalFluent-Multiply-System-Decimal,System-Decimal-'></a>
### Multiply(num,value) `method`

##### Summary

Multiplys the two nums

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') |  |
| value | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') |  |

<a name='M-Stone_Red_Utilities-FluentMath-DecimalFluent-Round-System-Decimal-'></a>
### Round() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DecimalFluent-Round-System-Decimal,System-MidpointRounding-'></a>
### Round() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DecimalFluent-Round-System-Decimal,System-Int32-'></a>
### Round() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DecimalFluent-Round-System-Decimal,System-Int32,System-MidpointRounding-'></a>
### Round() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DecimalFluent-Sign-System-Decimal-'></a>
### Sign() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DecimalFluent-Subtract-System-Decimal,System-Decimal-'></a>
### Subtract(num,value) `method`

##### Summary

Subtracts the two nums

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') |  |
| value | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') |  |

<a name='M-Stone_Red_Utilities-FluentMath-DecimalFluent-ToDouble-System-Decimal-'></a>
### ToDouble(num) `method`

##### Summary

Converts number to [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal')

##### Returns

Number as [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') |  |

<a name='M-Stone_Red_Utilities-FluentMath-DecimalFluent-ToInt16-System-Decimal-'></a>
### ToInt16(num) `method`

##### Summary

Converts number to [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16')

##### Returns

Number as [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') |  |

<a name='M-Stone_Red_Utilities-FluentMath-DecimalFluent-ToInt32-System-Decimal-'></a>
### ToInt32(num) `method`

##### Summary

Converts number to [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32')

##### Returns

Number as [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') |  |

<a name='M-Stone_Red_Utilities-FluentMath-DecimalFluent-ToInt64-System-Decimal-'></a>
### ToInt64(num) `method`

##### Summary

Converts number to [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64')

##### Returns

Number as [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') |  |

<a name='M-Stone_Red_Utilities-FluentMath-DecimalFluent-ToSingle-System-Decimal-'></a>
### ToSingle(num) `method`

##### Summary

Converts number to [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single')

##### Returns

Number as [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') |  |

<a name='M-Stone_Red_Utilities-FluentMath-DecimalFluent-Truncate-System-Decimal-'></a>
### Truncate() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Stone_Red_Utilities-FluentMath-DoubleFluent'></a>
## DoubleFluent `type`

##### Namespace

Stone_Red_Utilities.FluentMath

##### Summary

DoubleFluent class

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Abs-System-Double-'></a>
### Abs() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Acos-System-Double-'></a>
### Acos() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Acosh-System-Double-'></a>
### Acosh() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Add-System-Double,System-Double-'></a>
### Add(num,value) `method`

##### Summary

Adds the two nums

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') |  |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') |  |

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Asin-System-Double-'></a>
### Asin() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Asinh-System-Double-'></a>
### Asinh() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Atan-System-Double-'></a>
### Atan() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Atan2-System-Double,System-Double-'></a>
### Atan2() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Atanh-System-Double-'></a>
### Atanh() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Cbrt-System-Double-'></a>
### Cbrt() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Ceiling-System-Double-'></a>
### Ceiling() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Clamp-System-Double,System-Double,System-Double-'></a>
### Clamp() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Cos-System-Double-'></a>
### Cos() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Cosh-System-Double-'></a>
### Cosh() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Divide-System-Double,System-Double-'></a>
### Divide(num,value) `method`

##### Summary

Divides the two nums

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') |  |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') |  |

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Exp-System-Double-'></a>
### Exp() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Floor-System-Double-'></a>
### Floor() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-IEEERemainder-System-Double,System-Double-'></a>
### IEEERemainder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Log-System-Double-'></a>
### Log() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Log-System-Double,System-Double-'></a>
### Log() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Log10-System-Double-'></a>
### Log10() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Multiply-System-Double,System-Double-'></a>
### Multiply(num,value) `method`

##### Summary

Multiplys the two nums

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') |  |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') |  |

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Pow-System-Double,System-Double-'></a>
### Pow() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Round-System-Double-'></a>
### Round() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Round-System-Double,System-MidpointRounding-'></a>
### Round() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Round-System-Double,System-Int32-'></a>
### Round() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Round-System-Double,System-Int32,System-MidpointRounding-'></a>
### Round() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Sign-System-Double-'></a>
### Sign() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Sin-System-Double-'></a>
### Sin() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Sinh-System-Double-'></a>
### Sinh() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Sqrt-System-Double-'></a>
### Sqrt() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Subtract-System-Double,System-Double-'></a>
### Subtract(num,value) `method`

##### Summary

Subtracts the two nums

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') |  |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') |  |

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Tan-System-Double-'></a>
### Tan() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Tanh-System-Double-'></a>
### Tanh() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-ToDecimal-System-Double-'></a>
### ToDecimal(num) `method`

##### Summary

Converts number to [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal')

##### Returns

Number as [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') |  |

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-ToInt16-System-Double-'></a>
### ToInt16(num) `method`

##### Summary

Converts number to [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16')

##### Returns

Number as [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') |  |

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-ToInt32-System-Double-'></a>
### ToInt32(num) `method`

##### Summary

Converts number to [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32')

##### Returns

Number as [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') |  |

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-ToInt64-System-Double-'></a>
### ToInt64(num) `method`

##### Summary

Converts number to [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64')

##### Returns

Number as [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') |  |

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-ToSingle-System-Double-'></a>
### ToSingle(num) `method`

##### Summary

Converts number to [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single')

##### Returns

Number as [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') |  |

<a name='M-Stone_Red_Utilities-FluentMath-DoubleFluent-Truncate-System-Double-'></a>
### Truncate() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Stone_Red_Utilities-Logging-FormatConfig'></a>
## FormatConfig `type`

##### Namespace

Stone_Red_Utilities.Logging

##### Summary

Foramt configuration.

<a name='P-Stone_Red_Utilities-Logging-FormatConfig-ConsoleFormat'></a>
### ConsoleFormat `property`

##### Summary

The format for the console.

<a name='P-Stone_Red_Utilities-Logging-FormatConfig-DebugConsoleFormat'></a>
### DebugConsoleFormat `property`

##### Summary

The format for the debug console.

<a name='P-Stone_Red_Utilities-Logging-FormatConfig-FileFormat'></a>
### FileFormat `property`

##### Summary

The format for the log file.

<a name='T-Stone_Red_Utilities-FluentMath-Int16Fluent'></a>
## Int16Fluent `type`

##### Namespace

Stone_Red_Utilities.FluentMath

##### Summary

IntegerFluent class

<a name='M-Stone_Red_Utilities-FluentMath-Int16Fluent-Abs-System-Int16-'></a>
### Abs() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-Int16Fluent-Add-System-Int16,System-Int16-'></a>
### Add(num,value) `method`

##### Summary

Adds the two nums

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') |  |
| value | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') |  |

<a name='M-Stone_Red_Utilities-FluentMath-Int16Fluent-Clamp-System-Int16,System-Int16,System-Int16-'></a>
### Clamp() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-Int16Fluent-Divide-System-Int16,System-Int16-'></a>
### Divide(num,value) `method`

##### Summary

Divides the two nums

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') |  |
| value | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') |  |

<a name='M-Stone_Red_Utilities-FluentMath-Int16Fluent-Multiply-System-Int16,System-Int16-'></a>
### Multiply(num,value) `method`

##### Summary

Multiplys the two nums

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') |  |
| value | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') |  |

<a name='M-Stone_Red_Utilities-FluentMath-Int16Fluent-Sign-System-Int16-'></a>
### Sign() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-Int16Fluent-Subtract-System-Int16,System-Int16-'></a>
### Subtract(num,value) `method`

##### Summary

Subtracts the two nums

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') |  |
| value | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') |  |

<a name='M-Stone_Red_Utilities-FluentMath-Int16Fluent-ToDecimal-System-Int16-'></a>
### ToDecimal(num) `method`

##### Summary

Converts number to [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal')

##### Returns

Number as [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') |  |

<a name='M-Stone_Red_Utilities-FluentMath-Int16Fluent-ToDouble-System-Int16-'></a>
### ToDouble(num) `method`

##### Summary

Converts number to [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double')

##### Returns

Number as [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') |  |

<a name='M-Stone_Red_Utilities-FluentMath-Int16Fluent-ToInt32-System-Int16-'></a>
### ToInt32(num) `method`

##### Summary

Converts number to [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32')

##### Returns

Number as [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') |  |

<a name='M-Stone_Red_Utilities-FluentMath-Int16Fluent-ToInt64-System-Int16-'></a>
### ToInt64(num) `method`

##### Summary

Converts number to [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64')

##### Returns

Number as [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') |  |

<a name='M-Stone_Red_Utilities-FluentMath-Int16Fluent-ToSingle-System-Int16-'></a>
### ToSingle(num) `method`

##### Summary

Converts number to [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single')

##### Returns

Number as [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') |  |

<a name='T-Stone_Red_Utilities-FluentMath-Int32Fluent'></a>
## Int32Fluent `type`

##### Namespace

Stone_Red_Utilities.FluentMath

##### Summary

IntegerFluent class

<a name='M-Stone_Red_Utilities-FluentMath-Int32Fluent-Abs-System-Int32-'></a>
### Abs() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-Int32Fluent-Add-System-Int32,System-Int32-'></a>
### Add(num,value) `method`

##### Summary

Adds the two nums

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Stone_Red_Utilities-FluentMath-Int32Fluent-Clamp-System-Int32,System-Int32,System-Int32-'></a>
### Clamp() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-Int32Fluent-Divide-System-Int32,System-Int32-'></a>
### Divide(num,value) `method`

##### Summary

Divides the two nums

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Stone_Red_Utilities-FluentMath-Int32Fluent-Multiply-System-Int32,System-Int32-'></a>
### Multiply(num,value) `method`

##### Summary

Multiplys the two nums

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Stone_Red_Utilities-FluentMath-Int32Fluent-Sign-System-Int32-'></a>
### Sign() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-Int32Fluent-Subtract-System-Int32,System-Int32-'></a>
### Subtract(num,value) `method`

##### Summary

Subtracts the two nums

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Stone_Red_Utilities-FluentMath-Int32Fluent-ToDecimal-System-Int32-'></a>
### ToDecimal(num) `method`

##### Summary

Converts number to [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal')

##### Returns

Number as [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Stone_Red_Utilities-FluentMath-Int32Fluent-ToDouble-System-Int32-'></a>
### ToDouble(num) `method`

##### Summary

Converts number to [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double')

##### Returns

Number as [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Stone_Red_Utilities-FluentMath-Int32Fluent-ToInt16-System-Int32-'></a>
### ToInt16(num) `method`

##### Summary

Converts number to [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16')

##### Returns

Number as [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Stone_Red_Utilities-FluentMath-Int32Fluent-ToInt64-System-Int32-'></a>
### ToInt64(num) `method`

##### Summary

Converts number to [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64')

##### Returns

Number as [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Stone_Red_Utilities-FluentMath-Int32Fluent-ToSingle-System-Int32-'></a>
### ToSingle(num) `method`

##### Summary

Converts number to [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single')

##### Returns

Number as [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='T-Stone_Red_Utilities-FluentMath-Int64Fluent'></a>
## Int64Fluent `type`

##### Namespace

Stone_Red_Utilities.FluentMath

##### Summary

IntegerFluent class

<a name='M-Stone_Red_Utilities-FluentMath-Int64Fluent-Abs-System-Int64-'></a>
### Abs() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-Int64Fluent-Add-System-Int64,System-Int64-'></a>
### Add(num,value) `method`

##### Summary

Adds the two nums

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |

<a name='M-Stone_Red_Utilities-FluentMath-Int64Fluent-Clamp-System-Int64,System-Int64,System-Int64-'></a>
### Clamp() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-Int64Fluent-Divide-System-Int64,System-Int64-'></a>
### Divide(num,value) `method`

##### Summary

Divides the two nums

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |

<a name='M-Stone_Red_Utilities-FluentMath-Int64Fluent-Multiply-System-Int64,System-Int64-'></a>
### Multiply(num,value) `method`

##### Summary

Multiplys the two nums

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |

<a name='M-Stone_Red_Utilities-FluentMath-Int64Fluent-Sign-System-Int64-'></a>
### Sign() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-Int64Fluent-Subtract-System-Int64,System-Int64-'></a>
### Subtract(num,value) `method`

##### Summary

Subtracts the two nums

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |

<a name='M-Stone_Red_Utilities-FluentMath-Int64Fluent-ToDecimal-System-Int64-'></a>
### ToDecimal(num) `method`

##### Summary

Converts number to [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal')

##### Returns

Number as [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |

<a name='M-Stone_Red_Utilities-FluentMath-Int64Fluent-ToDouble-System-Int64-'></a>
### ToDouble(num) `method`

##### Summary

Converts number to [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double')

##### Returns

Number as [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |

<a name='M-Stone_Red_Utilities-FluentMath-Int64Fluent-ToInt16-System-Int64-'></a>
### ToInt16(num) `method`

##### Summary

Converts number to [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16')

##### Returns

Number as [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |

<a name='M-Stone_Red_Utilities-FluentMath-Int64Fluent-ToInt32-System-Int64-'></a>
### ToInt32(num) `method`

##### Summary

Converts number to [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32')

##### Returns

Number as [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |

<a name='M-Stone_Red_Utilities-FluentMath-Int64Fluent-ToSingle-System-Int64-'></a>
### ToSingle(num) `method`

##### Summary

Converts number to [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single')

##### Returns

Number as [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |

<a name='T-Stone_Red_Utilities-Logging-LogConfig'></a>
## LogConfig `type`

##### Namespace

Stone_Red_Utilities.Logging

##### Summary

Logging configuration.

<a name='P-Stone_Red_Utilities-Logging-LogConfig-DebugConfig'></a>
### DebugConfig `property`

##### Summary

The configuration for [Debug](#F-Stone_Red_Utilities-Logging-LogSeverity-Debug 'Stone_Red_Utilities.Logging.LogSeverity.Debug') messages.

<a name='P-Stone_Red_Utilities-Logging-LogConfig-ErrorConfig'></a>
### ErrorConfig `property`

##### Summary

The configuration for [Error](#F-Stone_Red_Utilities-Logging-LogSeverity-Error 'Stone_Red_Utilities.Logging.LogSeverity.Error') messages.

<a name='P-Stone_Red_Utilities-Logging-LogConfig-FatalConfig'></a>
### FatalConfig `property`

##### Summary

The configuration for [Fatal](#F-Stone_Red_Utilities-Logging-LogSeverity-Fatal 'Stone_Red_Utilities.Logging.LogSeverity.Fatal') messages.

<a name='P-Stone_Red_Utilities-Logging-LogConfig-FormatConfig'></a>
### FormatConfig `property`

##### Summary

The configuration for the message format.

<a name='P-Stone_Red_Utilities-Logging-LogConfig-InfoConfig'></a>
### InfoConfig `property`

##### Summary

The configuration for [Info](#F-Stone_Red_Utilities-Logging-LogSeverity-Info 'Stone_Red_Utilities.Logging.LogSeverity.Info') messages.

<a name='P-Stone_Red_Utilities-Logging-LogConfig-WarnConfig'></a>
### WarnConfig `property`

##### Summary

The configuration for [Warn](#F-Stone_Red_Utilities-Logging-LogSeverity-Warn 'Stone_Red_Utilities.Logging.LogSeverity.Warn') messages.

<a name='T-Stone_Red_Utilities-Logging-LogFormatType'></a>
## LogFormatType `type`

##### Namespace

Stone_Red_Utilities.Logging

##### Summary

Specifies the info type of the log message format.

<a name='F-Stone_Red_Utilities-Logging-LogFormatType-DateTime'></a>
### DateTime `constants`

##### Summary

The [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') of the log message.

<a name='F-Stone_Red_Utilities-Logging-LogFormatType-FilePath'></a>
### FilePath `constants`

##### Summary

The file path of the log message.

<a name='F-Stone_Red_Utilities-Logging-LogFormatType-LineNumber'></a>
### LineNumber `constants`

##### Summary

The line number of the log message.

<a name='F-Stone_Red_Utilities-Logging-LogFormatType-LogSeverity'></a>
### LogSeverity `constants`

##### Summary

The [LogSeverity](#T-Stone_Red_Utilities-Logging-LogSeverity 'Stone_Red_Utilities.Logging.LogSeverity') of the log message.

<a name='F-Stone_Red_Utilities-Logging-LogFormatType-MemberName'></a>
### MemberName `constants`

##### Summary

The member name of the log message.

<a name='F-Stone_Red_Utilities-Logging-LogFormatType-Message'></a>
### Message `constants`

##### Summary

The message of the log message.

<a name='F-Stone_Red_Utilities-Logging-LogFormatType-Source'></a>
### Source `constants`

##### Summary

The source of the log message.

<a name='T-Stone_Red_Utilities-Logging-LogSeverity'></a>
## LogSeverity `type`

##### Namespace

Stone_Red_Utilities.Logging

##### Summary

Specifies the severity of the log message.

<a name='F-Stone_Red_Utilities-Logging-LogSeverity-Debug'></a>
### Debug `constants`

##### Summary

Logs that contain the most detailed messages.

<a name='F-Stone_Red_Utilities-Logging-LogSeverity-Error'></a>
### Error `constants`

##### Summary

Logs that highlight when the flow of execution is stopped due to a failure.

<a name='F-Stone_Red_Utilities-Logging-LogSeverity-Fatal'></a>
### Fatal `constants`

##### Summary

Logs that contain the most severe level of error. This type of error indicate that immediate attention may be required.

<a name='F-Stone_Red_Utilities-Logging-LogSeverity-Info'></a>
### Info `constants`

##### Summary

Logs that track the general flow of the application.

<a name='F-Stone_Red_Utilities-Logging-LogSeverity-Warn'></a>
### Warn `constants`

##### Summary

Logs that highlight an abnormal activity in the flow of execution.

<a name='T-Stone_Red_Utilities-Logging-LogTarget'></a>
## LogTarget `type`

##### Namespace

Stone_Red_Utilities.Logging

##### Summary

Specifies the target of the log message.

<a name='F-Stone_Red_Utilities-Logging-LogTarget-Console'></a>
### Console `constants`

##### Summary

Writes log to console

<a name='F-Stone_Red_Utilities-Logging-LogTarget-DebugConsole'></a>
### DebugConsole `constants`

##### Summary

Writes log to debug console

<a name='F-Stone_Red_Utilities-Logging-LogTarget-File'></a>
### File `constants`

##### Summary

Writes log to file

<a name='T-Stone_Red_Utilities-Logging-Logger'></a>
## Logger `type`

##### Namespace

Stone_Red_Utilities.Logging

##### Summary

Class used for logging

<a name='P-Stone_Red_Utilities-Logging-Logger-Config'></a>
### Config `property`

##### Summary

The logging configuration.

<a name='M-Stone_Red_Utilities-Logging-Logger-ClearLogFile-Stone_Red_Utilities-Logging-LogSeverity-'></a>
### ClearLogFile() `method`

##### Summary

Clears the log file

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-Logging-Logger-Log-System-String,System-String,Stone_Red_Utilities-Logging-LogSeverity,System-String,System-String,System-Int32-'></a>
### Log(message,source,logSeverity,memberName,sourceFilePath,sourceLineNumber) `method`

##### Summary

Log the message to the specified output

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| logSeverity | [Stone_Red_Utilities.Logging.LogSeverity](#T-Stone_Red_Utilities-Logging-LogSeverity 'Stone_Red_Utilities.Logging.LogSeverity') |  |
| memberName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| sourceFilePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| sourceLineNumber | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Stone_Red_Utilities-Logging-Logger-Log-System-String,Stone_Red_Utilities-Logging-LogSeverity,System-String,System-String,System-Int32-'></a>
### Log(message,logSeverity,memberName,sourceFilePath,sourceLineNumber) `method`

##### Summary

Log the message to the specified output

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| logSeverity | [Stone_Red_Utilities.Logging.LogSeverity](#T-Stone_Red_Utilities-Logging-LogSeverity 'Stone_Red_Utilities.Logging.LogSeverity') |  |
| memberName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| sourceFilePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| sourceLineNumber | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Stone_Red_Utilities-Logging-Logger-LogIf-System-Boolean,System-String,System-String,Stone_Red_Utilities-Logging-LogSeverity,System-String,System-String,System-Int32-'></a>
### LogIf(condition,message,source,logSeverity,memberName,sourceFilePath,sourceLineNumber) `method`

##### Summary

Log the message to the specified output if the condition is met

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| logSeverity | [Stone_Red_Utilities.Logging.LogSeverity](#T-Stone_Red_Utilities-Logging-LogSeverity 'Stone_Red_Utilities.Logging.LogSeverity') |  |
| memberName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| sourceFilePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| sourceLineNumber | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Stone_Red_Utilities-Logging-Logger-LogIf-System-Boolean,System-String,Stone_Red_Utilities-Logging-LogSeverity,System-String,System-String,System-Int32-'></a>
### LogIf(condition,message,logSeverity,memberName,sourceFilePath,sourceLineNumber) `method`

##### Summary

Log the message to the specified output if the condition is met

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| logSeverity | [Stone_Red_Utilities.Logging.LogSeverity](#T-Stone_Red_Utilities-Logging-LogSeverity 'Stone_Red_Utilities.Logging.LogSeverity') |  |
| memberName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| sourceFilePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| sourceLineNumber | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='T-Stone_Red_Utilities-Logging-OutputConfig'></a>
## OutputConfig `type`

##### Namespace

Stone_Red_Utilities.Logging

##### Summary

Output configuration.

<a name='P-Stone_Red_Utilities-Logging-OutputConfig-Color'></a>
### Color `property`

##### Summary

The onsole color of the log message.

<a name='P-Stone_Red_Utilities-Logging-OutputConfig-FilePath'></a>
### FilePath `property`

##### Summary

The log file path.

<a name='P-Stone_Red_Utilities-Logging-OutputConfig-LogTarget'></a>
### LogTarget `property`

##### Summary

The target for the log message.

<a name='T-Stone_Red_Utilities-RandomExtentions-RandomExt'></a>
## RandomExt `type`

##### Namespace

Stone_Red_Utilities.RandomExtentions

##### Summary

[Random](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Random 'System.Random') Extentions

<a name='M-Stone_Red_Utilities-RandomExtentions-RandomExt-NextBool-System-Random-'></a>
### NextBool(random) `method`

##### Summary

Returns a random [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') using the [Random](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Random 'System.Random') class

##### Returns

Returns `true` or `false`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| random | [System.Random](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Random 'System.Random') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | `random` is `null` |

<a name='M-Stone_Red_Utilities-RandomExtentions-RandomExt-NextEnum``1-System-Random-'></a>
### NextEnum\`\`1(random) `method`

##### Summary

Returns a random item from the specified [Enum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Enum 'System.Enum') using the [Random](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Random 'System.Random') class

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| random | [System.Random](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Random 'System.Random') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-Stone_Red_Utilities-RandomExtentions-RandomExt-NextItem``1-System-Random,System-Collections-Generic-IEnumerable{``0}-'></a>
### NextItem\`\`1(random,collection) `method`

##### Summary

Returns an random item from the specified `collection` using the [Random](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Random 'System.Random') class

##### Returns

Returns a random item from the specified `collection`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| random | [System.Random](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Random 'System.Random') |  |
| collection | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | `collection` is `null` |

<a name='T-Stone_Red_Utilities-FluentMath-Shapes-Rectangle'></a>
## Rectangle `type`

##### Namespace

Stone_Red_Utilities.FluentMath.Shapes

##### Summary

Represents a rectangle

<a name='M-Stone_Red_Utilities-FluentMath-Shapes-Rectangle-#ctor-System-Double,System-Double-'></a>
### #ctor(length,width) `constructor`

##### Summary

Creates a new rectangle instance

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| length | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') |  |
| width | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') |  |

<a name='P-Stone_Red_Utilities-FluentMath-Shapes-Rectangle-Area'></a>
### Area `property`

##### Summary

The area of the [Rectangle](#T-Stone_Red_Utilities-FluentMath-Shapes-Rectangle 'Stone_Red_Utilities.FluentMath.Shapes.Rectangle')

<a name='P-Stone_Red_Utilities-FluentMath-Shapes-Rectangle-Diagonal'></a>
### Diagonal `property`

##### Summary

The diagonal of the [Rectangle](#T-Stone_Red_Utilities-FluentMath-Shapes-Rectangle 'Stone_Red_Utilities.FluentMath.Shapes.Rectangle')

<a name='P-Stone_Red_Utilities-FluentMath-Shapes-Rectangle-Length'></a>
### Length `property`

##### Summary

The length of the [Rectangle](#T-Stone_Red_Utilities-FluentMath-Shapes-Rectangle 'Stone_Red_Utilities.FluentMath.Shapes.Rectangle')

<a name='P-Stone_Red_Utilities-FluentMath-Shapes-Rectangle-Perimeter'></a>
### Perimeter `property`

##### Summary

The perimeter of the [Rectangle](#T-Stone_Red_Utilities-FluentMath-Shapes-Rectangle 'Stone_Red_Utilities.FluentMath.Shapes.Rectangle')

<a name='P-Stone_Red_Utilities-FluentMath-Shapes-Rectangle-Width'></a>
### Width `property`

##### Summary

The width of the [Rectangle](#T-Stone_Red_Utilities-FluentMath-Shapes-Rectangle 'Stone_Red_Utilities.FluentMath.Shapes.Rectangle')

<a name='T-Stone_Red_Utilities-Reflection-Reflection'></a>
## Reflection `type`

##### Namespace

Stone_Red_Utilities.Reflection

##### Summary

Reflection class

<a name='M-Stone_Red_Utilities-Reflection-Reflection-CopyProperties``1-System-Object-'></a>
### CopyProperties\`\`1(obj) `method`

##### Summary

Copies all properties of an object to a new one.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-Stone_Red_Utilities-Reflection-Reflection-CopyProperties``1-System-Object,``0-'></a>
### CopyProperties\`\`1(obj,newObj) `method`

##### Summary

Copies all properties of an object to a different one.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| newObj | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='T-Stone_Red_Utilities-FluentMath-SingleFluent'></a>
## SingleFluent `type`

##### Namespace

Stone_Red_Utilities.FluentMath

##### Summary

FloatFluent class

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Abs-System-Single-'></a>
### Abs() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Acos-System-Single-'></a>
### Acos() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Acosh-System-Single-'></a>
### Acosh() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Add-System-Single,System-Single-'></a>
### Add(num,value) `method`

##### Summary

Adds the two nums

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') |  |
| value | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') |  |

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Asin-System-Single-'></a>
### Asin() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Asinh-System-Single-'></a>
### Asinh() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Atan-System-Single-'></a>
### Atan() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Atan2-System-Single,System-Single-'></a>
### Atan2() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Atanh-System-Single-'></a>
### Atanh() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Cbrt-System-Single-'></a>
### Cbrt() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Ceiling-System-Single-'></a>
### Ceiling() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Clamp-System-Single,System-Single,System-Single-'></a>
### Clamp() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Cos-System-Single-'></a>
### Cos() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Cosh-System-Single-'></a>
### Cosh() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Divide-System-Single,System-Single-'></a>
### Divide(num,value) `method`

##### Summary

Divides the two nums

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') |  |
| value | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') |  |

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Exp-System-Single-'></a>
### Exp() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Floor-System-Single-'></a>
### Floor() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-IEEERemainder-System-Single,System-Single-'></a>
### IEEERemainder() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Log-System-Single-'></a>
### Log() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Log-System-Single,System-Single-'></a>
### Log() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Log10-System-Single-'></a>
### Log10() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Multiply-System-Single,System-Single-'></a>
### Multiply(num,value) `method`

##### Summary

Multiplys the two nums

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') |  |
| value | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') |  |

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Pow-System-Single,System-Single-'></a>
### Pow() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Round-System-Single-'></a>
### Round() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Round-System-Single,System-MidpointRounding-'></a>
### Round() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Round-System-Single,System-Int32-'></a>
### Round() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Round-System-Single,System-Int32,System-MidpointRounding-'></a>
### Round() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Sign-System-Single-'></a>
### Sign() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Sin-System-Single-'></a>
### Sin() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Sinh-System-Single-'></a>
### Sinh() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Sqrt-System-Single-'></a>
### Sqrt() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Subtract-System-Single,System-Single-'></a>
### Subtract(num,value) `method`

##### Summary

Subtracts the two nums

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') |  |
| value | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') |  |

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Tan-System-Single-'></a>
### Tan() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Tanh-System-Single-'></a>
### Tanh() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-ToDecimal-System-Single-'></a>
### ToDecimal(num) `method`

##### Summary

Converts number to [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal')

##### Returns

Number as [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') |  |

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-ToDouble-System-Single-'></a>
### ToDouble(num) `method`

##### Summary

Converts number to [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double')

##### Returns

Number as [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') |  |

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-ToInt16-System-Single-'></a>
### ToInt16(num) `method`

##### Summary

Converts number to [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16')

##### Returns

Number as [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') |  |

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-ToInt32-System-Single-'></a>
### ToInt32(num) `method`

##### Summary

Converts number to [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32')

##### Returns

Number as [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') |  |

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-ToInt64-System-Single-'></a>
### ToInt64(num) `method`

##### Summary

Converts number to [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64')

##### Returns

Number as [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') |  |

<a name='M-Stone_Red_Utilities-FluentMath-SingleFluent-Truncate-System-Single-'></a>
### Truncate() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Stone_Red_Utilities-StringExtentions-StringExt'></a>
## StringExt `type`

##### Namespace

Stone_Red_Utilities.StringExtentions

##### Summary

[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') Extentions

<a name='M-Stone_Red_Utilities-StringExtentions-StringExt-CorrectNewLine-System-String-'></a>
### CorrectNewLine(str) `method`

##### Summary

Uses the correct newline [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') defined for this environment.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Stone_Red_Utilities-StringExtentions-StringExt-EqualsIgnoreCase-System-String,System-String-'></a>
### EqualsIgnoreCase(value,str) `method`

##### Summary

Determines whether this instance and another specified [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') object have the same value regardless of upper and lower case.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Stone_Red_Utilities-StringExtentions-StringExt-EqualsIgnoreSpaces-System-String,System-String-'></a>
### EqualsIgnoreSpaces(value,str) `method`

##### Summary

Determines whether this instance and another specified [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') object have the same value regardless of spaces.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Stone_Red_Utilities-StringExtentions-StringExt-EqualsIgnoreSpacesAndCase-System-String,System-String-'></a>
### EqualsIgnoreSpacesAndCase(value,str) `method`

##### Summary

Determines whether this instance and another specified [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') object have the same value regardless of upper and lower case and spaces.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Stone_Red_Utilities-StringExtentions-StringExt-RemoveWhitespaces-System-String-'></a>
### RemoveWhitespaces(str) `method`

##### Summary

Revoves all whitespaces from the specified [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Stone_Red_Utilities-StringExtentions-StringExt-Reverse-System-String-'></a>
### Reverse(str) `method`

##### Summary

Reverses the specified [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Stone_Red_Utilities-StringExtentions-StringExt-ToFileName-System-String,System-Boolean-'></a>
### ToFileName(str,allowSpaces) `method`

##### Summary

Removes all invalid chars from the specified [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| allowSpaces | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-Stone_Red_Utilities-StringExtentions-StringExt-ToPath-System-String,System-Boolean-'></a>
### ToPath(str,allowSpaces) `method`

##### Summary

Removes all invalid chars from the specified [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| allowSpaces | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-Stone_Red_Utilities-StringExtentions-StringExt-Truncate-System-String,System-Int32-'></a>
### Truncate(str,length) `method`

##### Summary

Truncates a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') to the specified length.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Stone_Red_Utilities-StringExtentions-StringExt-Truncate-System-String,System-Int32,System-Boolean-'></a>
### Truncate(str,length,ellipsis) `method`

##### Summary

Truncates a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') to the specified length.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| ellipsis | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-Stone_Red_Utilities-CollectionExtentions-TableStyle'></a>
## TableStyle `type`

##### Namespace

Stone_Red_Utilities.CollectionExtentions

##### Summary

Table Style

<a name='F-Stone_Red_Utilities-CollectionExtentions-TableStyle-Alternative'></a>
### Alternative `constants`

##### Summary

The alternative representaion of the table

<a name='F-Stone_Red_Utilities-CollectionExtentions-TableStyle-Default'></a>
### Default `constants`

##### Summary

The default representaion of the table

<a name='F-Stone_Red_Utilities-CollectionExtentions-TableStyle-List'></a>
### List `constants`

##### Summary

The list representaion of the table

<a name='F-Stone_Red_Utilities-CollectionExtentions-TableStyle-Minimum'></a>
### Minimum `constants`

##### Summary

The minimal representation of the table
