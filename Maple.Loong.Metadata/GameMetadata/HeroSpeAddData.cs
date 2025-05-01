namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."HeroSpeAddData"]
    /// [System.Object]
    /// [System.ICloneable]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_HeroSpeAddData>, Ptr_HeroSpeAddData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "HeroSpeAddData", "HeroSpeAddData")]
    public partial class HeroSpeAddData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_HeroSpeAddData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_HeroSpeAddData(System.IntPtr ptr) => new Ptr_HeroSpeAddData(ptr);
            public static implicit operator System.IntPtr(Ptr_HeroSpeAddData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_HeroSpeAddData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."HeroSpeAddData"]
        /// </summary>
        partial struct Ptr_HeroSpeAddData
        {
            /// <summary>
            /// 0x10 System.Collections.Generic.Dictionary<System.Int32 , System.Single> heroSpeAddData
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroSpeAddData", "System.Collections.Generic.Dictionary<System.Int32,System.Single>")]
            public partial nint HERO_SPE_ADD_DATA { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."HeroSpeAddData"]
        /// </summary>
        partial struct Ptr_HeroSpeAddData
        {
            /// <summary>
            /// static  HeroSpeAddData op_Addition(HeroSpeAddData a, HeroSpeAddData b)
            /// </summary>
            /// <param name = "a">class HeroSpeAddData</param>
            /// <param name = "b">class HeroSpeAddData</param>
            /// <returns>class HeroSpeAddData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Addition", "HeroSpeAddData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroSpeAddData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroSpeAddData", 1)]
            public static partial nint OP_ADDITION(nint a, nint b); 
*/
            /// <summary>
            /// static  HeroSpeAddData op_Multiply(HeroSpeAddData a, System.Int32 b)
            /// </summary>
            /// <param name = "a">class HeroSpeAddData</param>
            /// <param name = "b">struct System.Int32</param>
            /// <returns>class HeroSpeAddData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Multiply", "HeroSpeAddData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroSpeAddData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public static partial nint OP_MULTIPLY(nint a, System.Int32 b); 
*/
            /// <summary>
            /// static  HeroSpeAddData op_Multiply(HeroSpeAddData a, System.Single b)
            /// </summary>
            /// <param name = "a">class HeroSpeAddData</param>
            /// <param name = "b">struct System.Single</param>
            /// <returns>class HeroSpeAddData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Multiply", "HeroSpeAddData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroSpeAddData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public static partial nint OP_MULTIPLY(nint a, System.Single b); 
*/
            /// <summary>
            /// static  HeroSpeAddData op_Subtraction(HeroSpeAddData a, HeroSpeAddData b)
            /// </summary>
            /// <param name = "a">class HeroSpeAddData</param>
            /// <param name = "b">class HeroSpeAddData</param>
            /// <returns>class HeroSpeAddData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Subtraction", "HeroSpeAddData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroSpeAddData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroSpeAddData", 1)]
            public static partial nint OP_SUBTRACTION(nint a, nint b); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void Change(HeroSpeAddDataType speAddDataType, System.Single delta)
            /// </summary>
            /// <param name = "speAddDataType">enum HeroSpeAddDataType</param>
            /// <param name = "delta">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Change", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroSpeAddDataType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial void CHANGE(HeroSpeAddDataType speAddDataType, System.Single delta); 
*/
            /// <summary>
            ///   System.Void Change(System.Int32 speAddDataType, System.Single delta)
            /// </summary>
            /// <param name = "speAddDataType">struct System.Int32</param>
            /// <param name = "delta">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Change", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial void CHANGE(System.Int32 speAddDataType, System.Single delta); 
*/
            /// <summary>
            ///   System.Void ChangeMulti(HeroSpeAddDataType speAddDataType, System.Single multi)
            /// </summary>
            /// <param name = "speAddDataType">enum HeroSpeAddDataType</param>
            /// <param name = "multi">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeMulti", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroSpeAddDataType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial void CHANGE_MULTI(HeroSpeAddDataType speAddDataType, System.Single multi); 
*/
            /// <summary>
            ///   System.Void ChangeMulti(System.Int32 speAddDataType, System.Single multi)
            /// </summary>
            /// <param name = "speAddDataType">struct System.Int32</param>
            /// <param name = "multi">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeMulti", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial void CHANGE_MULTI(System.Int32 speAddDataType, System.Single multi); 
*/
            /// <summary>
            ///   System.Object Clone()
            /// </summary>
            /// <returns>class System.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Clone", "System.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint CLONE(); 
*/
            /// <summary>
            ///   System.Single Get(HeroSpeAddDataType speAddDataType)
            /// </summary>
            /// <param name = "speAddDataType">enum HeroSpeAddDataType</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Get", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroSpeAddDataType", 0)]
            public partial System.Single GET(HeroSpeAddDataType speAddDataType); 
*/
            /// <summary>
            ///   System.Single Get(System.Int32 speAddDataType)
            /// </summary>
            /// <param name = "speAddDataType">struct System.Int32</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Get", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Single GET(System.Int32 speAddDataType); 
*/
            /// <summary>
            ///   System.String GetDescribe()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDescribe", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_DESCRIBE(); 
*/
            /// <summary>
            ///   System.String GetDescribe(System.Boolean useColor)
            /// </summary>
            /// <param name = "useColor">struct System.Boolean</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDescribe", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial nint GET_DESCRIBE(System.Boolean useColor); 
*/
            /// <summary>
            ///   System.String GetDescribe(System.Boolean useColor, System.Boolean newLine)
            /// </summary>
            /// <param name = "useColor">struct System.Boolean</param>
            /// <param name = "newLine">struct System.Boolean</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDescribe", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial nint GET_DESCRIBE(System.Boolean useColor, System.Boolean newLine); 
*/
            /// <summary>
            ///   System.String GetDescribe(System.Int32 startID)
            /// </summary>
            /// <param name = "startID">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDescribe", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_DESCRIBE(System.Int32 startID); 
*/
            /// <summary>
            ///   System.String GetDescribe(System.Int32 startID, System.Boolean useColor)
            /// </summary>
            /// <param name = "startID">struct System.Int32</param>
            /// <param name = "useColor">struct System.Boolean</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDescribe", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial nint GET_DESCRIBE(System.Int32 startID, System.Boolean useColor); 
*/
            /// <summary>
            ///   System.String GetDescribe(System.Int32 startID, System.Int32 endID)
            /// </summary>
            /// <param name = "startID">struct System.Int32</param>
            /// <param name = "endID">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDescribe", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_DESCRIBE(System.Int32 startID, System.Int32 endID); 
*/
            /// <summary>
            ///   System.String GetDescribe(System.Int32 startID, System.Int32 endID, System.Boolean useColor, System.Boolean newLine)
            /// </summary>
            /// <param name = "startID">struct System.Int32</param>
            /// <param name = "endID">struct System.Int32</param>
            /// <param name = "useColor">struct System.Boolean</param>
            /// <param name = "newLine">struct System.Boolean</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDescribe", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            public partial nint GET_DESCRIBE(System.Int32 startID, System.Int32 endID, System.Boolean useColor, System.Boolean newLine); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<System.Int32> GetKeys()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKeys", "System.Collections.Generic.List<System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_KEYS(); 
*/
            /// <summary>
            ///   System.Single GetValue()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetValue", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_VALUE(); 
*/
            /// <summary>
            ///   System.Boolean isEmpty()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("isEmpty", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean IS_EMPTY(); 
*/
            /// <summary>
            ///   HeroSpeAddData Multi(System.Single b)
            /// </summary>
            /// <param name = "b">struct System.Single</param>
            /// <returns>class HeroSpeAddData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Multi", "HeroSpeAddData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial nint MULTI(System.Single b); 
*/
            /// <summary>
            ///   System.Void Reset()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Reset", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RESET(); 
*/
            /// <summary>
            ///   HeroSpeAddData Set(HeroSpeAddDataType speAddDataType, System.Single value)
            /// </summary>
            /// <param name = "speAddDataType">enum HeroSpeAddDataType</param>
            /// <param name = "value">struct System.Single</param>
            /// <returns>class HeroSpeAddData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Set", "HeroSpeAddData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroSpeAddDataType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial nint SET(HeroSpeAddDataType speAddDataType, System.Single value); 
*/
            /// <summary>
            ///   HeroSpeAddData Set(System.Int32 speAddDataType, System.Single value)
            /// </summary>
            /// <param name = "speAddDataType">struct System.Int32</param>
            /// <param name = "value">struct System.Single</param>
            /// <returns>class HeroSpeAddData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Set", "HeroSpeAddData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial nint SET(System.Int32 speAddDataType, System.Single value); 
*/
        }
    }
}