using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Jabra.NET.Sdk.Core;
using Jabra.NET.Sdk.Core.Types;
using Jabra.NET.Sdk.Modules.RemoteMMI.Types;

namespace DiscoMode
{
    public static class RandomExtensions
    {
        public static T NextItem<T>(this Random random, IEnumerable<T> items)
        {
            return items.ElementAt(random.Next(items.Count()));
        }

        public static IEnumerable<T> Shuffle<T>(this Random random, IEnumerable<T> items)
        {
            var itemsLeft = new List<T>(items);
            while (itemsLeft.Count > 0)
            {
                var index = random.Next(itemsLeft.Count);
                yield return itemsLeft[index];
                itemsLeft.RemoveAt(index);
            }
        }
    }

    public static class DiscoMode
    {
        public static readonly IEnumerable<Led> AllLeds = Enum.GetValues<Led>();
        public static readonly IEnumerable<LedColor> AllColors = Enum.GetValues<LedColor>();
        public static readonly IEnumerable<LedInterval> CoolIntervals = new LedInterval[]
        {
            LedInterval.SLOW,
            LedInterval.FAST
        };

        public static async Task<int> Main(string[] _)
        {
            // Initialize the SDK
            IApi sdk = Init.InitSdk();

            return 0;
        }
    }
}
