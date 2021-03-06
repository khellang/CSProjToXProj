﻿using System;
using System.Collections.Generic;

namespace CSProjToXProj.SourceFiles
{
    public class ProjectMetadata
    {

        public ProjectMetadata(string targetFrameworkVersion, string rootNamespace, Guid guid, string[] projectReferences, string[] frameworkReferences,
            string outputType)
        {
            TargetFrameworkVersion = targetFrameworkVersion;
            RootNamespace = rootNamespace;
            Guid = guid;
            ProjectReferences = projectReferences;
            FrameworkReferences = frameworkReferences;
            OutputType = outputType;
        }
        public string TargetFrameworkVersion { get; }
        public string RootNamespace { get;  }
        public Guid Guid { get;  }
        public IReadOnlyList<string> ProjectReferences { get;  }
        public IReadOnlyList<string> FrameworkReferences { get;  }
        public string OutputType { get;}
    }
}