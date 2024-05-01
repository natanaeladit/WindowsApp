using NSubstitute;
using FluentAssertions;

namespace WindowsApp.Test
{
    public class SongTest
    {
        [Fact]
        public void Song_ViewModel_Should_Equal_To_Song_Model()
        {
            var song = Substitute.For<Song>();
            var songViewModel = new SongViewModel(song);
            songViewModel.ArtistName.Should().Be(song.ArtistName);
            songViewModel.ArtistName = string.Empty;
            songViewModel.ArtistName.Should().Be(string.Empty);
        }
    }
}