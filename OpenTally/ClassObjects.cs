using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OpenTally
{
    public class DeviceID
    {
        public string deviceName { get; set; }
        public string deviceId { get; set; }
        public string listenerType { get; set; }
    }

    public class Devices
    {
        /* Example Devices:
        [
          {
            "name": "Cam 1",
            "description": "Cam 1 Tally",
            "enabled": true,
            "id": "f5eacd0f"
          },
          {
            "name": "Cam 2",
            "description": "Cam 2 Tally",
            "enabled": true,
            "id": "2b4735bf"
          }
        ]
        */
        public string name { get; set; }
        public string description { get; set; }
        public string tslAddress { get; set; }
        public bool enabled { get; set; }
        public string id { get; set; }
        public bool linkedPreview { get; set; }
        public bool linkedProgram { get; set; }
    }


    public class DeviceStates
    {
        public string deviceId { get; set; }
        public string busId { get; set; }
        public List<sources> sources { get; set; }
        //public List<linkedSources> linkedSources { get; set; }
        public List<sources> linkedSources { get; set; }
        public bool active { get; set; }
    }

    public class sources
    {
        /* Example sources:
         "sources": [
          {
            "sourceId": "TEST",
            "address": "TEST"
          }
        ]
        */
        public string sourceId { get; set; }
        public string address { get; set; }
    }

    //public class linkedSources
    //{
    //    /* Example linkedSources:

    //    */
    //    public string sourceId { get; set; }
    //    public string address { get; set; }
    //}

    public class BusOptions
    {
        /* Example Bus Options:
        [
            {
            "id": "e393251c",
            "label": "Preview",
            "type": "preview"
            },
            {
            "id": "334e4eda",
            "label": "Program",
            "type": "program"
            }
        ]
        */
        public string id { get; set; }
        public string label { get; set; }
        public string type { get; set; }

    }

    public class Config
    {
        public string source1 { get; set; }
        public string source2 { get; set; }
        public string source3 { get; set; }
        public string source4 { get; set; }
        public string source5 { get; set; }
        public string source6 { get; set; }
        public string source7 { get; set; }
        public string source8 { get; set; }
        public string wsPassword { get; set; }
        public string wsPort { get; set; }
        public string wsAddress { get; set; }
        public string cut_bus { get; set; }
        public string mode { get; set; }
    }

}