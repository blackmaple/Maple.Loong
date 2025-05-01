namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."PlotData"]
    /// [System.Object]
    /// [System.ICloneable]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_PlotData>, Ptr_PlotData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "PlotData", "PlotData")]
    public partial class PlotData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_PlotData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_PlotData(System.IntPtr ptr) => new Ptr_PlotData(ptr);
            public static implicit operator System.IntPtr(Ptr_PlotData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_PlotData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."PlotData"]
        /// </summary>
        partial struct Ptr_PlotData
        {
            /// <summary>
            /// 0x10 System.String plotName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("plotName", "System.String")]
            public partial nint PLOT_NAME { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Boolean spePlot
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("spePlot", "System.Boolean")]
            public partial System.Boolean SPE_PLOT { get; set; } 
*/

            /// <summary>
            /// 0x1C System.Int32 plotID
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("plotID", "System.Int32")]
            public partial System.Int32 PLOT_ID { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.List<PlotRandomHeroData> plotRandomHero
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<PlotRandomHeroData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("plotRandomHero", "System.Collections.Generic.List<PlotRandomHeroData>")]
            public partial nint PLOT_RANDOM_HERO { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Boolean differentForce
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("differentForce", "System.Boolean")]
            public partial System.Boolean DIFFERENT_FORCE { get; set; } 
*/

            /// <summary>
            /// 0x2C System.Int32 targetHeroID
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("targetHeroID", "System.Int32")]
            public partial System.Int32 TARGET_HERO_ID { get; set; } 
*/

            /// <summary>
            /// 0x30 System.String plotCallFuc
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("plotCallFuc", "System.String")]
            public partial nint PLOT_CALL_FUC { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Boolean randomStartPlot
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("randomStartPlot", "System.Boolean")]
            public partial System.Boolean RANDOM_START_PLOT { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Collections.Generic.List<SinglePlotData> plotDatas
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<SinglePlotData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("plotDatas", "System.Collections.Generic.List<SinglePlotData>")]
            public partial nint PLOT_DATAS { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."PlotData"]
        /// </summary>
        partial struct Ptr_PlotData
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Object Clone()
            /// </summary>
            /// <returns>class System.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Clone", "System.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint CLONE(); 
*/
        }
    }
}