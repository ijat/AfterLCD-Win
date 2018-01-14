namespace AfterLCD_client.Model
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class HardwareMonitor
    {

        private HardwareMonitorHardwareMonitorHeader hardwareMonitorHeaderField;

        private HardwareMonitorHardwareMonitorEntry[] hardwareMonitorEntriesField;

        private HardwareMonitorHardwareMonitorGpuEntries hardwareMonitorGpuEntriesField;

        /// <remarks/>
        public HardwareMonitorHardwareMonitorHeader HardwareMonitorHeader
        {
            get
            {
                return this.hardwareMonitorHeaderField;
            }
            set
            {
                this.hardwareMonitorHeaderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("HardwareMonitorEntry", IsNullable = false)]
        public HardwareMonitorHardwareMonitorEntry[] HardwareMonitorEntries
        {
            get
            {
                return this.hardwareMonitorEntriesField;
            }
            set
            {
                this.hardwareMonitorEntriesField = value;
            }
        }

        /// <remarks/>
        public HardwareMonitorHardwareMonitorGpuEntries HardwareMonitorGpuEntries
        {
            get
            {
                return this.hardwareMonitorGpuEntriesField;
            }
            set
            {
                this.hardwareMonitorGpuEntriesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HardwareMonitorHardwareMonitorHeader
    {

        private uint signatureField;

        private uint versionField;

        private byte headerSizeField;

        private byte entryCountField;

        private ushort entrySizeField;

        private uint timeField;

        private byte gpuEntryCountField;

        private ushort gpuEntrySizeField;

        /// <remarks/>
        public uint signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        /// <remarks/>
        public uint version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public byte headerSize
        {
            get
            {
                return this.headerSizeField;
            }
            set
            {
                this.headerSizeField = value;
            }
        }

        /// <remarks/>
        public byte entryCount
        {
            get
            {
                return this.entryCountField;
            }
            set
            {
                this.entryCountField = value;
            }
        }

        /// <remarks/>
        public ushort entrySize
        {
            get
            {
                return this.entrySizeField;
            }
            set
            {
                this.entrySizeField = value;
            }
        }

        /// <remarks/>
        public uint time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        /// <remarks/>
        public byte gpuEntryCount
        {
            get
            {
                return this.gpuEntryCountField;
            }
            set
            {
                this.gpuEntryCountField = value;
            }
        }

        /// <remarks/>
        public ushort gpuEntrySize
        {
            get
            {
                return this.gpuEntrySizeField;
            }
            set
            {
                this.gpuEntrySizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HardwareMonitorHardwareMonitorEntry
    {

        private string srcNameField;

        private string srcUnitsField;

        private string localizedSrcNameField;

        private string localizedSrcUnitsField;

        private string recommendedFormatField;

        private float dataField;

        private byte minLimitField;

        private ushort maxLimitField;

        private string flagsField;

        private uint gpuField;

        private byte srcIdField;

        /// <remarks/>
        public string srcName
        {
            get
            {
                return this.srcNameField;
            }
            set
            {
                this.srcNameField = value;
            }
        }

        /// <remarks/>
        public string srcUnits
        {
            get
            {
                return this.srcUnitsField;
            }
            set
            {
                this.srcUnitsField = value;
            }
        }

        /// <remarks/>
        public string localizedSrcName
        {
            get
            {
                return this.localizedSrcNameField;
            }
            set
            {
                this.localizedSrcNameField = value;
            }
        }

        /// <remarks/>
        public string localizedSrcUnits
        {
            get
            {
                return this.localizedSrcUnitsField;
            }
            set
            {
                this.localizedSrcUnitsField = value;
            }
        }

        /// <remarks/>
        public string recommendedFormat
        {
            get
            {
                return this.recommendedFormatField;
            }
            set
            {
                this.recommendedFormatField = value;
            }
        }

        /// <remarks/>
        public float data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }

        /// <remarks/>
        public byte minLimit
        {
            get
            {
                return this.minLimitField;
            }
            set
            {
                this.minLimitField = value;
            }
        }

        /// <remarks/>
        public ushort maxLimit
        {
            get
            {
                return this.maxLimitField;
            }
            set
            {
                this.maxLimitField = value;
            }
        }

        /// <remarks/>
        public string flags
        {
            get
            {
                return this.flagsField;
            }
            set
            {
                this.flagsField = value;
            }
        }

        /// <remarks/>
        public uint gpu
        {
            get
            {
                return this.gpuField;
            }
            set
            {
                this.gpuField = value;
            }
        }

        /// <remarks/>
        public byte srcId
        {
            get
            {
                return this.srcIdField;
            }
            set
            {
                this.srcIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HardwareMonitorHardwareMonitorGpuEntries
    {

        private HardwareMonitorHardwareMonitorGpuEntriesHardwareMonitorGpuEntry hardwareMonitorGpuEntryField;

        /// <remarks/>
        public HardwareMonitorHardwareMonitorGpuEntriesHardwareMonitorGpuEntry HardwareMonitorGpuEntry
        {
            get
            {
                return this.hardwareMonitorGpuEntryField;
            }
            set
            {
                this.hardwareMonitorGpuEntryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HardwareMonitorHardwareMonitorGpuEntriesHardwareMonitorGpuEntry
    {

        private string gpuIdField;

        private string familyField;

        private string deviceField;

        private decimal driverField;

        private string bIOSField;

        private byte memAmountField;

        /// <remarks/>
        public string gpuId
        {
            get
            {
                return this.gpuIdField;
            }
            set
            {
                this.gpuIdField = value;
            }
        }

        /// <remarks/>
        public string family
        {
            get
            {
                return this.familyField;
            }
            set
            {
                this.familyField = value;
            }
        }

        /// <remarks/>
        public string device
        {
            get
            {
                return this.deviceField;
            }
            set
            {
                this.deviceField = value;
            }
        }

        /// <remarks/>
        public decimal driver
        {
            get
            {
                return this.driverField;
            }
            set
            {
                this.driverField = value;
            }
        }

        /// <remarks/>
        public string BIOS
        {
            get
            {
                return this.bIOSField;
            }
            set
            {
                this.bIOSField = value;
            }
        }

        /// <remarks/>
        public byte memAmount
        {
            get
            {
                return this.memAmountField;
            }
            set
            {
                this.memAmountField = value;
            }
        }
    }
}
