/*
 Navicat Premium Data Transfer

 Source Server         : MYSQL_[127.0.0.1]
 Source Server Type    : MySQL
 Source Server Version : 100216
 Source Host           : 127.0.0.1:3306
 Source Schema         : tokenrepository

 Target Server Type    : MySQL
 Target Server Version : 100216
 File Encoding         : 65001

 Date: 18/01/2022 17:14:52
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for tb_securitylevelbasis
-- ----------------------------
DROP TABLE IF EXISTS `tb_securitylevelbasis`;
CREATE TABLE `tb_securitylevelbasis`  (
  `SecurityKey` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL COMMENT '密码策略标识符',
  `SecurityLevel` int(11) NOT NULL COMMENT '密码策略等级',
  `SecurityLength` int(11) NOT NULL COMMENT '密码长度',
  `CharacterElement` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL COMMENT '密码组成元字符串',
  `IsValid` bit(1) DEFAULT NULL COMMENT '是否生效',
  `Remark` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL COMMENT '备注',
  `CreateDate` datetime(0) DEFAULT NULL COMMENT '创建日期',
  `ModifyDate` datetime(0) DEFAULT NULL COMMENT '修改日期',
  PRIMARY KEY (`SecurityKey`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for tb_tokenbasis
-- ----------------------------
DROP TABLE IF EXISTS `tb_tokenbasis`;
CREATE TABLE `tb_tokenbasis`  (
  `ID` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL COMMENT '密码标识符',
  `Token` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL COMMENT '密码，Base64加密字符串',
  `SecurityKey` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL COMMENT '密码策略等级',
  `IsEnabledOfDateTurnOn` bit(1) DEFAULT NULL COMMENT '是否启用开启日期管控策略',
  `EnabledDate` datetime(0) DEFAULT NULL COMMENT '密码开启日期，开启日期大于等于最新北京时间方可查看密码',
  `Prompt` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL COMMENT '提示信息',
  `IsValid` bit(1) DEFAULT NULL COMMENT '是否生效',
  `Remark` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL COMMENT '备注',
  `CreateDate` datetime(0) DEFAULT NULL COMMENT '创建日期',
  `ModifyDate` datetime(0) DEFAULT NULL COMMENT '修改日期',
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

SET FOREIGN_KEY_CHECKS = 1;
