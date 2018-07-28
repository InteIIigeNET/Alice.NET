﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alice.Models
{
	public enum RequestType
	{
		SimpleUtterance,
		ButtonPressed
	}

	public class Request
	{
		[JsonProperty("command")]
		public string Command { get; set; }

		[JsonProperty("type")]
		public RequestType Type { get; set; }

		[JsonProperty("original_utterance")]
		public string OriginalUtterance { get; set; }

		[JsonProperty("payload")]
		public JObject Payload { get; set; }
	}
}