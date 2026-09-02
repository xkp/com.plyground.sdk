# Plyground SDK

This package is the public authoring surface for Plyground Unity controllers.

It provides `IPlygroundModule`, `IPlygroundGameModule`, `IPlygroundCharacterModule`,
the base controller types, and the model types used by those contracts. The types retain
their existing global names so controller projects can adopt this package without a
namespace migration.

Generated Plyground projects install this package as a local `file:` dependency. The same
contents can be published from a private `com.plyground.sdk` Git repository for third-party
controller development.
