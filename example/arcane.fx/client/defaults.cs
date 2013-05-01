//-----------------------------------------------------------------------------
// Torque Game Engine 
// Copyright (C) GarageGames.com, Inc.
//-----------------------------------------------------------------------------

// The master server is declared with the server defaults, which is
// loaded on both clients & dedicated servers.  If the server mod
// is not loaded on a client, then the master must be defined. 
// $pref::Master[0] = "2:master.garagegames.com:28002";

$pref::Player::Name = "Orc Shaman";
$pref::Player::defaultFov = 90;
$pref::Player::zoomSpeed = 0;
$pref::Player::corpsesHiddenFromRayCast = false;
$pref::Audio::usePlayerCentricListener = true;
$pref::afxSpellButton::unknownSpellBitmap = "arcane.fx/client/ui/icons/unknown";
$pref::afxSpellButton::spellCooldownBitmaps = "arcane.fx/client/ui/icons/cooldown/cooldown";
$pref::AFX::enableFXLoadFiltering = false;
$pref::AFX::fxLevelOfDetail = "2";
$pref::AFX::clickToTargetSelf = false;
$pref::AFX::targetSelectionMask = $TypeMasks::PlayerObjectType | $TypeMasks::CorpseObjectType;
$pref::AFX::missileCollisionMask = $TypeMasks::PlayerObjectType | 
                                   $TypeMasks::CorpseObjectType | 
                                   $TypeMasks::InteriorObjectType |
                                   $TypeMasks::StaticObjectType |
                                   $TypeMasks::DamagableItemObjectType |
                                   $TypeMasks::VehicleObjectType;

$pref::Net::LagThreshold = 400;
$pref::Net::Port = 28000;
// AFX
$pref::Net::PacketRateToClient = "32";
$pref::Net::PacketRateToServer = "32";
$pref::Net::PacketSize = "450";
// AFX

$pref::shadows = "2";
$pref::HudMessageLogSize = 40;
$pref::ChatHudLength = 1;


$pref::Input::LinkMouseSensitivity = 1;
$pref::Input::MouseEnabled = 1;
$pref::Input::JoystickEnabled = 0;
$pref::Input::KeyboardTurnSpeed = 0.1;

$pref::sceneLighting::cacheSize = 20000;
$pref::sceneLighting::purgeMethod = "lastCreated";
$pref::sceneLighting::cacheLighting = 1;
$pref::sceneLighting::terrainGenerateLevel = 1;

$pref::ts::detailAdjust = 0.45;

$pref::Terrain::DynamicLights = 1;
$pref::Interior::TexturedFog = 0;

$pref::Video::displayDevice = "OpenGL";
$pref::Video::allowOpenGL = 1;
$pref::Video::allowD3D = 1;
$pref::Video::preferOpenGL = 1;
$pref::Video::appliedPref = 0;
$pref::Video::disableVerticalSync = 1;
$pref::Video::monitorNum = 0;
$pref::Video::windowedRes = "800 600";
$pref::Video::screenShotFormat = "PNG";

$pref::OpenGL::force16BitTexture = "0";
$pref::OpenGL::forcePalettedTexture = "0";
$pref::OpenGL::maxHardwareLights = 3;
$pref::VisibleDistanceMod = 1.0;

$pref::Audio::driver = "OpenAL";
$pref::Audio::forceMaxDistanceUpdate = 0;
$pref::Audio::environmentEnabled = 0;
$pref::Audio::masterVolume   = 0.8;
$pref::Audio::channelVolume1 = 0.8;
$pref::Audio::channelVolume2 = 0.8;
$pref::Audio::channelVolume3 = 0.8;
$pref::Audio::channelVolume4 = 0.8;
$pref::Audio::channelVolume5 = 0.8;
$pref::Audio::channelVolume6 = 0.8;
$pref::Audio::channelVolume7 = 0.8;
$pref::Audio::channelVolume8 = 0.8;

// DATABLOCK CACHE CODE <<
$pref::Client::EnableDatablockCache = true;
$pref::Client::DatablockCacheFilename = "arcane.fx/client/afx_datablock_cache_c.dbc";
// DATABLOCK CACHE CODE >>


