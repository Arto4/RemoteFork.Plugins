﻿using System.Collections.Generic;

namespace RemoteFork.Plugins.AceStream.Commands {
    public class GetRootListCommand : ICommand {
        public List<Item> GetItems(IPluginContext context = null, params string[] data) {
            var items = new List<Item>();
            var item = new Item {
                Name = "Поиск",
                Link = "searchtvtoace",
                Type = ItemType.DIRECTORY,
                SearchOn = "Поиск",
                ImageLink = "http://s1.iconbird.com/ico/0612/MustHave/w256h2561339195991Search256x256.png",
                Description =
                    "<html><font face=\"Arial\" size=\"5\"><b>ПОИСК ТВ ТРАНСЛЯЦИЙ...</font></b><p><img width=\"100%\"  src=\"https://tvfeed.in/img/acestream-main.jpg\" />"
            };
            items.Add(item);

            item = new Item {
                Name = "Torrent TV",
                Type = ItemType.DIRECTORY,
                Link = "torrenttv",
                ImageLink = "https://cs5-2.4pda.to/7342878.png",
                Description = "<html><img src=\" http://torrent-tv.ru/images/logo.png\"></html><p>"
            };

            items.Add(item);

            item = new Item {
                Name = "AceStream.Net TV",
                Type = ItemType.DIRECTORY,
                Link = "acestreamnettv",
                ImageLink =
                    "http://lh3.googleusercontent.com/Vh58wclC2o-4lMfibmBqiuhY2j9vBZbxO4bTJCZtjZ1jeLNe0fgoYpy1888fgGa9EL0=w300",
                Description =
                    "<html><img src=\"http://static.acestream.net/sites/acestream/img/ACE-logo.png\"></html><p>"
            };

            items.Add(item);

            item = new Item {
                Type = ItemType.DIRECTORY,
                Name = "ALLFON-TV",
                Link = $"iproxy{AceStreamTV.SEPARATOR}allfon.all.iproxy",
                ImageLink = "http://allfon-tv.com/css/images/favicon.png",
                Description = "<html><img src=\"http://allfon-tv.com/css/images/favicon.png\"></html><p>"
            };
            items.Add(item);

            item = new Item {
                Type = ItemType.DIRECTORY,
                Name = "TV-P2P",
                Link = "tvp2p",
                ImageLink = "http://tv-p2p.ru/favicon.png",
                Description = "<html><img src=\"http://tv-p2p.ru/skin/p2p/images/logo.png\"></html><p>"
            };
            items.Add(item);

            AceStreamTV.IsIptv = false;
            return items;
        }
    }
}
