using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Feedz.Helpers;
namespace Feedz.Fixture
{
    [CollectionDefinition("Chrome Driver")]
    public class CollectionFixture : ICollectionFixture<TesteFixture>
    {

    }
}
