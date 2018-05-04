﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using BigfootDS;

namespace BigfootDS {

	[CreateAssetMenu(fileName = "BigfootWebColoursMetallic", menuName = "BigfootDS/WebColourDatabase - Metallic", order = 1)]
	public class BigfootWebColoursMetallic : SingletonScriptableObject<BigfootWebColoursMetallic> {
		static readonly string[] materialLocation = {"Assets/BigfootDS/_Common/Materials/Basic Colours - Metallic/"};

		public Material AliceBlue;
		public Material AntiqueWhite;
		public Material Aqua;
		public Material Aquamarine;
		public Material Azure;
		public Material Beige;
		public Material Bisque;
		public Material Black;
		public Material BlanchedAlmond;
		public Material Blue;
		public Material BlueViolet;
		public Material Brown;
		public Material BurlyWood;
		public Material CadetBlue;
		public Material Chartreuse;
		public Material Chocolate;
		public Material Coral;
		public Material CornflowerBlue;
		public Material Cornsilk;
		public Material Crimson;
		public Material Cyan;
		public Material DarkBlue;
		public Material DarkCyan;
		public Material DarkGoldenRod;
		public Material DarkGray;
		public Material DarkGrey;
		public Material DarkGreen;
		public Material DarkKhaki;
		public Material DarkMagenta;
		public Material DarkOliveGreen;
		public Material DarkOrange;
		public Material DarkOrchid;
		public Material DarkRed;
		public Material DarkSalmon;
		public Material DarkSeaGreen;
		public Material DarkSlateBlue;
		public Material DarkSlateGray;
		public Material DarkSlateGrey;
		public Material DarkTurquoise;
		public Material DarkViolet;
		public Material DeepPink;
		public Material DeepSkyBlue;
		public Material DimGray;
		public Material DimGrey;
		public Material DodgerBlue;
		public Material FireBrick;
		public Material FloralWhite;
		public Material ForestGreen;
		public Material Fuchsia;
		public Material Gainsboro;
		public Material GhostWhite;
		public Material Gold;
		public Material GoldenRod;
		public Material Gray;
		public Material Grey;
		public Material Green;
		public Material GreenYellow;
		public Material HoneyDew;
		public Material HotPink;
		public Material IndianRed;
		public Material Indigo;
		public Material Ivory;
		public Material Khaki;
		public Material Lavender;
		public Material LavenderBlush;
		public Material LawnGreen;
		public Material LemonChiffon;
		public Material LightBlue;
		public Material LightCoral;
		public Material LightCyan;
		public Material LightGoldenRodYellow;
		public Material LightGray;
		public Material LightGrey;
		public Material LightGreen;
		public Material LightPink;
		public Material LightSalmon;
		public Material LightSeaGreen;
		public Material LightSkyBlue;
		public Material LightSlateGray;
		public Material LightSlateGrey;
		public Material LightSteelBlue;
		public Material LightYellow;
		public Material Lime;
		public Material LimeGreen;
		public Material Linen;
		public Material Magenta;
		public Material Maroon;
		public Material MediumAquaMarine;
		public Material MediumBlue;
		public Material MediumOrchid;
		public Material MediumPurple;
		public Material MediumSeaGreen;
		public Material MediumSlateBlue;
		public Material MediumSpringGreen;
		public Material MediumTurquoise;
		public Material MediumVioletRed;
		public Material MidnightBlue;
		public Material MintCream;
		public Material MistyRose;
		public Material Moccasin;
		public Material NavajoWhite;
		public Material Navy;
		public Material OldLace;
		public Material Olive;
		public Material OliveDrab;
		public Material Orange;
		public Material OrangeRed;
		public Material Orchid;
		public Material PaleGoldenRod;
		public Material PaleGreen;
		public Material PaleTurquoise;
		public Material PaleVioletRed;
		public Material PapayaWhip;
		public Material PeachPuff;
		public Material Peru;
		public Material Pink;
		public Material Plum;
		public Material PowderBlue;
		public Material Purple;
		public Material RebeccaPurple;
		public Material Red;
		public Material RosyBrown;
		public Material RoyalBlue;
		public Material SaddleBrown;
		public Material Salmon;
		public Material SandyBrown;
		public Material SeaGreen;
		public Material SeaShell;
		public Material Sienna;
		public Material Silver;
		public Material SkyBlue;
		public Material SlateBlue;
		public Material SlateGray;
		public Material SlateGrey;
		public Material Snow;
		public Material SpringGreen;
		public Material SteelBlue;
		public Material Tan;
		public Material Teal;
		public Material Thistle;
		public Material Tomato;
		public Material Turquoise;
		public Material Violet;
		public Material Wheat;
		public Material White;
		public Material WhiteSmoke;
		public Material Yellow;
		public Material YellowGreen;

		public List<Material> materialsMetallic;
#if UNITY_EDITOR

        void OnEnable () {
			//Debug.Log ("OnEnable was called for the web colour metallic SO.");
			materialsMetallic.Clear();
			materialsMetallic.Add (AliceBlue = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "AliceBlue" + ".mat", typeof(Material)));
			if (AliceBlue == null) {
				Debug.Log ("Error in finding materials for default web colours SO. Tried searching for " + materialLocation[0] + "AliceBlue" + ".mat");
				return;
			}
			materialsMetallic.Add (AntiqueWhite = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "AntiqueWhite" + ".mat", typeof(Material)));
			materialsMetallic.Add (Aqua = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Aqua" + ".mat", typeof(Material)));
			materialsMetallic.Add (Aquamarine = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Aquamarine" + ".mat", typeof(Material)));
			materialsMetallic.Add (Azure = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Azure" + ".mat", typeof(Material)));
			materialsMetallic.Add (Beige = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Beige" + ".mat", typeof(Material)));
			materialsMetallic.Add (Bisque = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Bisque" + ".mat", typeof(Material)));
			materialsMetallic.Add (Black = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Black" + ".mat", typeof(Material)));
			materialsMetallic.Add (BlanchedAlmond = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "BlanchedAlmond" + ".mat", typeof(Material)));
			materialsMetallic.Add (Blue = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Blue" + ".mat", typeof(Material)));
			materialsMetallic.Add (BlueViolet = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "BlueViolet" + ".mat", typeof(Material)));
			materialsMetallic.Add (Brown = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Brown" + ".mat", typeof(Material)));
			materialsMetallic.Add (BurlyWood = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "BurlyWood" + ".mat", typeof(Material)));
			materialsMetallic.Add (CadetBlue = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "CadetBlue" + ".mat", typeof(Material)));
			materialsMetallic.Add (Chartreuse = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Chartreuse" + ".mat", typeof(Material)));
			materialsMetallic.Add (Chocolate = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Chocolate" + ".mat", typeof(Material)));
			materialsMetallic.Add (Coral = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Coral" + ".mat", typeof(Material)));
			materialsMetallic.Add (CornflowerBlue = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "CornflowerBlue" + ".mat", typeof(Material)));
			materialsMetallic.Add (Cornsilk = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Cornsilk" + ".mat", typeof(Material)));
			materialsMetallic.Add (Crimson = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Crimson" + ".mat", typeof(Material)));
			materialsMetallic.Add (Cyan = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Cyan" + ".mat", typeof(Material)));
			materialsMetallic.Add (DarkBlue = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "DarkBlue" + ".mat", typeof(Material)));
			materialsMetallic.Add (DarkCyan = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "DarkCyan" + ".mat", typeof(Material)));
			materialsMetallic.Add (DarkGoldenRod = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "DarkGoldenRod" + ".mat", typeof(Material)));
			materialsMetallic.Add (DarkGray = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "DarkGrey" + ".mat", typeof(Material)));
			materialsMetallic.Add (DarkGrey = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "DarkGrey" + ".mat", typeof(Material)));
			materialsMetallic.Add (DarkGreen = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "DarkGreen" + ".mat", typeof(Material)));
			materialsMetallic.Add (DarkKhaki = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "DarkKhaki" + ".mat", typeof(Material)));
			materialsMetallic.Add (DarkMagenta = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "DarkMagenta" + ".mat", typeof(Material)));
			materialsMetallic.Add (DarkOliveGreen = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "DarkOliveGreen" + ".mat", typeof(Material)));
			materialsMetallic.Add (DarkOrange = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "DarkOrange" + ".mat", typeof(Material)));
			materialsMetallic.Add (DarkOrchid = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "DarkOrchid" + ".mat", typeof(Material)));
			materialsMetallic.Add (DarkRed = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "DarkRed" + ".mat", typeof(Material)));
			materialsMetallic.Add (DarkSalmon = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "DarkSalmon" + ".mat", typeof(Material)));
			materialsMetallic.Add (DarkSeaGreen = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "DarkSeaGreen" + ".mat", typeof(Material)));
			materialsMetallic.Add (DarkSlateBlue = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "DarkSlateBlue" + ".mat", typeof(Material)));
			materialsMetallic.Add (DarkSlateGray = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "DarkSlateGrey" + ".mat", typeof(Material)));
			materialsMetallic.Add (DarkSlateGrey = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "DarkSlateGrey" + ".mat", typeof(Material)));
			materialsMetallic.Add (DarkTurquoise = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "DarkTurquoise" + ".mat", typeof(Material)));
			materialsMetallic.Add (DarkViolet = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "DarkViolet" + ".mat", typeof(Material)));
			materialsMetallic.Add (DeepPink = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "DeepPink" + ".mat", typeof(Material)));
			materialsMetallic.Add (DeepSkyBlue = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "DeepSkyBlue" + ".mat", typeof(Material)));
			materialsMetallic.Add (DimGray = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "DimGrey" + ".mat", typeof(Material)));
			materialsMetallic.Add (DimGrey = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "DimGrey" + ".mat", typeof(Material)));
			materialsMetallic.Add (DodgerBlue = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "DodgerBlue" + ".mat", typeof(Material)));
			materialsMetallic.Add (FireBrick = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "FireBrick" + ".mat", typeof(Material)));
			materialsMetallic.Add (FloralWhite = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "FloralWhite" + ".mat", typeof(Material)));
			materialsMetallic.Add (ForestGreen = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "ForestGreen" + ".mat", typeof(Material)));
			materialsMetallic.Add (Fuchsia = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Fuchsia" + ".mat", typeof(Material)));
			materialsMetallic.Add (Gainsboro = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Gainsboro" + ".mat", typeof(Material)));
			materialsMetallic.Add (GhostWhite = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "GhostWhite" + ".mat", typeof(Material)));
			materialsMetallic.Add (Gold = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Gold" + ".mat", typeof(Material)));
			materialsMetallic.Add (GoldenRod = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "GoldenRod" + ".mat", typeof(Material)));
			materialsMetallic.Add (Gray = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Grey" + ".mat", typeof(Material)));
			materialsMetallic.Add (Grey = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Grey" + ".mat", typeof(Material)));
			materialsMetallic.Add (Green = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Green" + ".mat", typeof(Material)));
			materialsMetallic.Add (GreenYellow = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "GreenYellow" + ".mat", typeof(Material)));
			materialsMetallic.Add (HoneyDew = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "HoneyDew" + ".mat", typeof(Material)));
			materialsMetallic.Add (HotPink = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "HotPink" + ".mat", typeof(Material)));
			materialsMetallic.Add (IndianRed = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "IndianRed" + ".mat", typeof(Material)));
			materialsMetallic.Add (Indigo = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Indigo" + ".mat", typeof(Material)));
			materialsMetallic.Add (Ivory = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Ivory" + ".mat", typeof(Material)));
			materialsMetallic.Add (Khaki = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Khaki" + ".mat", typeof(Material)));
			materialsMetallic.Add (Lavender = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Lavender" + ".mat", typeof(Material)));
			materialsMetallic.Add (LavenderBlush = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "LavenderBlush" + ".mat", typeof(Material)));
			materialsMetallic.Add (LawnGreen = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "LawnGreen" + ".mat", typeof(Material)));
			materialsMetallic.Add (LemonChiffon = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "LemonChiffon" + ".mat", typeof(Material)));
			materialsMetallic.Add (LightBlue = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "LightBlue" + ".mat", typeof(Material)));
			materialsMetallic.Add (LightCoral = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "LightCoral" + ".mat", typeof(Material)));
			materialsMetallic.Add (LightCyan = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "LightCyan" + ".mat", typeof(Material)));
			materialsMetallic.Add (LightGoldenRodYellow = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "LightGoldenRodYellow" + ".mat", typeof(Material)));
			materialsMetallic.Add (LightGray = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "LightGrey" + ".mat", typeof(Material)));
			materialsMetallic.Add (LightGrey = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "LightGrey" + ".mat", typeof(Material)));
			materialsMetallic.Add (LightGreen = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "LightGreen" + ".mat", typeof(Material)));
			materialsMetallic.Add (LightPink = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "LightPink" + ".mat", typeof(Material)));
			materialsMetallic.Add (LightSalmon = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "LightSalmon" + ".mat", typeof(Material)));
			materialsMetallic.Add (LightSeaGreen = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "LightSeaGreen" + ".mat", typeof(Material)));
			materialsMetallic.Add (LightSkyBlue = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "LightSkyBlue" + ".mat", typeof(Material)));
			materialsMetallic.Add (LightSlateGray = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "LightSlateGrey" + ".mat", typeof(Material)));
			materialsMetallic.Add (LightSlateGrey = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "LightSlateGrey" + ".mat", typeof(Material)));
			materialsMetallic.Add (LightSteelBlue = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "LightSteelBlue" + ".mat", typeof(Material)));
			materialsMetallic.Add (LightYellow = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "LightYellow" + ".mat", typeof(Material)));
			materialsMetallic.Add (Lime = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Lime" + ".mat", typeof(Material)));
			materialsMetallic.Add (LimeGreen = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "LimeGreen" + ".mat", typeof(Material)));
			materialsMetallic.Add (Linen = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Linen" + ".mat", typeof(Material)));
			materialsMetallic.Add (Magenta = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Magenta" + ".mat", typeof(Material)));
			materialsMetallic.Add (Maroon = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Maroon" + ".mat", typeof(Material)));
			materialsMetallic.Add (MediumAquaMarine = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "MediumAquaMarine" + ".mat", typeof(Material)));
			materialsMetallic.Add (MediumBlue = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "MediumBlue" + ".mat", typeof(Material)));
			materialsMetallic.Add (MediumOrchid = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "MediumOrchid" + ".mat", typeof(Material)));
			materialsMetallic.Add (MediumPurple = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "MediumPurple" + ".mat", typeof(Material)));
			materialsMetallic.Add (MediumSeaGreen = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "MediumSeaGreen" + ".mat", typeof(Material)));
			materialsMetallic.Add (MediumSlateBlue = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "MediumSlateBlue" + ".mat", typeof(Material)));
			materialsMetallic.Add (MediumSpringGreen = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "MediumSpringGreen" + ".mat", typeof(Material)));
			materialsMetallic.Add (MediumTurquoise = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "MediumTurquoise" + ".mat", typeof(Material)));
			materialsMetallic.Add (MediumVioletRed = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "MediumVioletRed" + ".mat", typeof(Material)));
			materialsMetallic.Add (MidnightBlue = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "MidnightBlue" + ".mat", typeof(Material)));
			materialsMetallic.Add (MintCream = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "MintCream" + ".mat", typeof(Material)));
			materialsMetallic.Add (MistyRose = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "MistyRose" + ".mat", typeof(Material)));
			materialsMetallic.Add (Moccasin = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Moccasin" + ".mat", typeof(Material)));
			materialsMetallic.Add (NavajoWhite = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "NavajoWhite" + ".mat", typeof(Material)));
			materialsMetallic.Add (Navy = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Navy" + ".mat", typeof(Material)));
			materialsMetallic.Add (OldLace = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "OldLace" + ".mat", typeof(Material)));
			materialsMetallic.Add (Olive = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Olive" + ".mat", typeof(Material)));
			materialsMetallic.Add (OliveDrab = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "OliveDrab" + ".mat", typeof(Material)));
			materialsMetallic.Add (Orange = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Orange" + ".mat", typeof(Material)));
			materialsMetallic.Add (OrangeRed = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "OrangeRed" + ".mat", typeof(Material)));
			materialsMetallic.Add (Orchid = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Orchid" + ".mat", typeof(Material)));
			materialsMetallic.Add (PaleGoldenRod = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "PaleGoldenRod" + ".mat", typeof(Material)));
			materialsMetallic.Add (PaleGreen = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "PaleGreen" + ".mat", typeof(Material)));
			materialsMetallic.Add (PaleTurquoise = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "PaleTurquoise" + ".mat", typeof(Material)));
			materialsMetallic.Add (PaleVioletRed = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "PaleVioletRed" + ".mat", typeof(Material)));
			materialsMetallic.Add (PapayaWhip = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "PapayaWhip" + ".mat", typeof(Material)));
			materialsMetallic.Add (PeachPuff = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "PeachPuff" + ".mat", typeof(Material)));
			materialsMetallic.Add (Peru = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Peru" + ".mat", typeof(Material)));
			materialsMetallic.Add (Pink = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Pink" + ".mat", typeof(Material)));
			materialsMetallic.Add (Plum = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Plum" + ".mat", typeof(Material)));
			materialsMetallic.Add (PowderBlue = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "PowderBlue" + ".mat", typeof(Material)));
			materialsMetallic.Add (Purple = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Purple" + ".mat", typeof(Material)));
			materialsMetallic.Add (RebeccaPurple = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "RebeccaPurple" + ".mat", typeof(Material)));
			materialsMetallic.Add (Red = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Red" + ".mat", typeof(Material)));
			materialsMetallic.Add (RosyBrown = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "RosyBrown" + ".mat", typeof(Material)));
			materialsMetallic.Add (RoyalBlue = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "RoyalBlue" + ".mat", typeof(Material)));
			materialsMetallic.Add (SaddleBrown = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "SaddleBrown" + ".mat", typeof(Material)));
			materialsMetallic.Add (Salmon = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Salmon" + ".mat", typeof(Material)));
			materialsMetallic.Add (SandyBrown = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "SandyBrown" + ".mat", typeof(Material)));
			materialsMetallic.Add (SeaGreen = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "SeaGreen" + ".mat", typeof(Material)));
			materialsMetallic.Add (SeaShell = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "SeaShell" + ".mat", typeof(Material)));
			materialsMetallic.Add (Sienna = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Sienna" + ".mat", typeof(Material)));
			materialsMetallic.Add (Silver = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Silver" + ".mat", typeof(Material)));
			materialsMetallic.Add (SkyBlue = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "SkyBlue" + ".mat", typeof(Material)));
			materialsMetallic.Add (SlateBlue = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "SlateBlue" + ".mat", typeof(Material)));
			materialsMetallic.Add (SlateGray = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "SlateGrey" + ".mat", typeof(Material)));
			materialsMetallic.Add (SlateGrey = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "SlateGrey" + ".mat", typeof(Material)));
			materialsMetallic.Add (Snow = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Snow" + ".mat", typeof(Material)));
			materialsMetallic.Add (SpringGreen = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "SpringGreen" + ".mat", typeof(Material)));
			materialsMetallic.Add (SteelBlue = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "SteelBlue" + ".mat", typeof(Material)));
			materialsMetallic.Add (Tan = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Tan" + ".mat", typeof(Material)));
			materialsMetallic.Add (Teal = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Teal" + ".mat", typeof(Material)));
			materialsMetallic.Add (Thistle = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Thistle" + ".mat", typeof(Material)));
			materialsMetallic.Add (Tomato = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Tomato" + ".mat", typeof(Material)));
			materialsMetallic.Add (Turquoise = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Turquoise" + ".mat", typeof(Material)));
			materialsMetallic.Add (Violet = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Violet" + ".mat", typeof(Material)));
			materialsMetallic.Add (Wheat = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Wheat" + ".mat", typeof(Material)));
			materialsMetallic.Add (White = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "White" + ".mat", typeof(Material)));
			materialsMetallic.Add (WhiteSmoke = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "WhiteSmoke" + ".mat", typeof(Material)));
			materialsMetallic.Add (Yellow = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "Yellow" + ".mat", typeof(Material)));
			materialsMetallic.Add (YellowGreen = (Material)AssetDatabase.LoadAssetAtPath(materialLocation[0] + "YellowGreen" + ".mat", typeof(Material)));
		}
#endif
    }
}