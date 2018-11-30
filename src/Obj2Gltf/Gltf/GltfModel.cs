﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Arctron.Gltf
{
    public class GltfModel
    {
        [JsonProperty("accessors")]
        public List<Accessor> Accessors { get; set; } = new List<Accessor>();
        [JsonProperty("asset")]
        public Asset Asset { get; set; } = new Asset { Generator = "arctron", Version = "2.0" };
        [JsonProperty("buffers")]
        public List<Buffer> Buffers { get; set; } = new List<Buffer>();
        [JsonProperty("bufferViews")]
        public List<BufferView> BufferViews { get; set; } = new List<BufferView>();
        [JsonProperty("images")]
        public List<Image> Images { get; set; } = new List<Image>();
        [JsonProperty("materials")]
        public List<Material> Materials { get; set; } = new List<Material>();
        [JsonProperty("meshes")]
        public List<Mesh> Meshes { get; set; } = new List<Mesh>();
        [JsonProperty("nodes")]
        public List<Node> Nodes { get; set; } = new List<Node>();
        [JsonProperty("samplers")]
        public List<Sampler> Samplers { get; set; } = new List<Sampler>();
        [JsonProperty("scene")]
        public int Scene { get; set; }
        [JsonProperty("scenes")]
        public List<Scene> Scenes { get; set; } = new List<Scene>();
        [JsonProperty("textures")]
        public List<Texture> Textures { get; set; } = new List<Texture>();


        public static GltfModel LoadFromJsonFile(string filePath)
        {
            var s = System.IO.File.ReadAllText(filePath, Encoding.UTF8);
            return JsonConvert.DeserializeObject<GltfModel>(s);
        }

    }
}